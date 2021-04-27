using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air3550
{
    public partial class FlightManLandingPage : Form
    {
        public FlightManLandingPage()
        {
            InitializeComponent();

            DataTable newEditTable = updateAccountGridViewTable();
            BindingSource SBind = new BindingSource();
            SBind.DataSource = newEditTable;
            flightsTableColumnSetup();
            flights_dataview.DataSource = SBind;
            flights_dataview.Refresh();

            FormDatabaseHelper.fillAirportsAbv(origin_combobox);
            FormDatabaseHelper.fillAirportsAbv(dest_combobox);

            flight_search_groupbox.Show();
            manifest_groupbox.Hide();
        }

        private void FlightManLandingPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Dispose();
            Login s = new Login();
            s.Visible = true;
        }

        // =================================================================================================
        // Print Manifest Functionality ====================================================================
        // =================================================================================================

        private void printManifest_btn_Click(object sender, EventArgs e)
        {
            flight_search_groupbox.Hide();
            manifest_groupbox.Show();

            int flightID = int.Parse(flights_dataview.CurrentRow.Cells["id"].Value.ToString());

            DataTable bookedFlightInfo = returnFlightInformation(flightID);
            DataTable flightTransactions = returnSingleFlightTransactions(flightID);

            fillDataManifest(bookedFlightInfo, flightTransactions);
        }

        private void manifest_close_button_Click(object sender, EventArgs e)
        {
            flight_search_groupbox.Show();
            manifest_groupbox.Hide();
        }

        private void fillDataManifest(DataTable flight, DataTable transactions)
        {
            single_flightID_label.Text = flight.Rows[0].Field<int>("id").ToString();
            single_originCode_label.Text = flight.Rows[0].Field<string>("originAbv");
            single_destCode_label.Text = flight.Rows[0].Field<string>("destAbv");
            single_depDate_label.Text = flight.Rows[0].Field<DateTime>("departureTime").ToString();
            single_arrivalDate_label.Text = flight.Rows[0].Field<DateTime>("arrivalTime").ToString();

            BindingSource SBind = new BindingSource();
            SBind.DataSource = transactions;
            manifest_datagridview.Columns.Clear();
            singleTransactionsTableColumnSetup();
            manifest_datagridview.DataSource = SBind;
            manifest_datagridview.Refresh();
        }

        // =================================================================================================
        // Location Based Search Functionality =============================================================
        // =================================================================================================

        private void origin_dest_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = origin_dest_checkbox.Checked;

            if (isChecked == true)
            {
                origin_combobox.Enabled = true;
                dest_combobox.Enabled = true;
                clearSort_button.Enabled = true;
            }
            else
            {
                origin_combobox.Enabled = false;
                dest_combobox.Enabled = false;
                clearSort_button.Enabled = false;
            }
        }

        private void clearSort_button_Click(object sender, EventArgs e)
        {
            origin_combobox.SelectedItem = null;
            dest_combobox.SelectedItem = null;

            updateTable();
        }

        private void origin_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTable();
        }

        private void dest_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTable();
        }

        // =================================================================================================
        // Date Based Search Functionality =================================================================
        // =================================================================================================

        private void date_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = date_checkbox.Checked;

            if (isChecked == true)
            {
                afterDate_DTP.Enabled = true;
                beforeDate_DTP.Enabled = true;
                date_after_checkbox.Enabled = true;
                date_before_checkbox.Enabled = true;
            }
            else
            {
                afterDate_DTP.Enabled = false;
                beforeDate_DTP.Enabled = false;
                date_after_checkbox.Enabled = false;
                date_before_checkbox.Enabled = false;
            }
        }

        private void date_after_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            updateTable();
        }

        private void date_before_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            updateTable();
        }

        private void afterDate_DTP_ValueChanged(object sender, EventArgs e)
        {
            updateTable();
        }

        private void beforeDate_DTP_ValueChanged(object sender, EventArgs e)
        {
            updateTable();
        }

        // =================================================================================================
        // General and Helper Functionality ================================================================
        // =================================================================================================

        private void updateTable()
        {
            DataTable newEditTable = new DataTable();
            BindingSource SBind = new BindingSource();

            bool location = false, date = false;
            location = origin_dest_checkbox.Checked;
            date = date_checkbox.Checked;

            bool multiPassTableSort = false;

            if (location && date) multiPassTableSort = true;

            if (location && !multiPassTableSort)
            {


                string origin = origin_combobox.Text;
                string destination = dest_combobox.Text;

                if (origin_combobox.SelectedItem != null && dest_combobox.SelectedItem != null)
                {
                    newEditTable = updateAccountGridViewTable(origin, destination);
                }
                else if (origin_combobox.SelectedItem != null && dest_combobox.SelectedItem == null)
                {
                    newEditTable = updateAccountGridViewTable(origin, null);
                }
                else if (origin_combobox.SelectedItem == null && dest_combobox.SelectedItem != null)
                {
                    newEditTable = updateAccountGridViewTable(null, destination);
                }
                else
                {
                    newEditTable = updateAccountGridViewTable(null, null);
                }
            }
            else if (date && !multiPassTableSort)
            {
                DateTime before = beforeDate_DTP.Value.Date;
                DateTime after = afterDate_DTP.Value.Date;

                if (date_after_checkbox.Checked && date_before_checkbox.Checked)
                {
                    newEditTable = updateGridViewTableWithDate(true, true, before, after);
                }
                else if (!date_after_checkbox.Checked && date_before_checkbox.Checked)
                {
                    newEditTable = updateGridViewTableWithDate(true, false, before);
                }
                else if (date_after_checkbox.Checked && !date_before_checkbox.Checked)
                {
                    newEditTable = updateGridViewTableWithDate(false, true, default, after);
                }
                else
                {
                    newEditTable = updateGridViewTableWithDate(false, false);
                }
            }
            else if (multiPassTableSort)
            {
                bool tableInitialized = false;
                if (location)
                {
                    string origin = origin_combobox.Text;
                    string destination = dest_combobox.Text;

                    if (origin_combobox.SelectedItem != null && dest_combobox.SelectedItem != null)
                    {
                        newEditTable = updateAccountGridViewTable(origin, destination);
                    }
                    else if (origin_combobox.SelectedItem != null && dest_combobox.SelectedItem == null)
                    {
                        newEditTable = updateAccountGridViewTable(origin, null);
                    }
                    else if (origin_combobox.SelectedItem == null && dest_combobox.SelectedItem != null)
                    {
                        newEditTable = updateAccountGridViewTable(null, destination);
                    }
                    else
                    {
                        newEditTable = updateAccountGridViewTable(null, null);
                    }

                    tableInitialized = true;
                }

                if (date && !tableInitialized)
                {
                    DateTime before = beforeDate_DTP.Value.Date;
                    DateTime after = afterDate_DTP.Value.Date;

                    if (date_after_checkbox.Checked && date_before_checkbox.Checked)
                    {
                        newEditTable = updateGridViewTableWithDate(true, true, before, after);
                    }
                    else if (!date_after_checkbox.Checked && date_before_checkbox.Checked)
                    {
                        newEditTable = updateGridViewTableWithDate(true, false, before);
                    }
                    else if (date_after_checkbox.Checked && !date_before_checkbox.Checked)
                    {
                        newEditTable = updateGridViewTableWithDate(false, true, default, after);
                    }
                    else
                    {
                        newEditTable = updateGridViewTableWithDate(false, false);
                    }

                    tableInitialized = true;
                }
                else if (date && tableInitialized)
                {
                    DateTime before = beforeDate_DTP.Value.Date;
                    DateTime after = afterDate_DTP.Value.Date;

                    string beforeStr = before.ToString();
                    string afterStr = after.ToString();

                    string search = null;
                    if (date_after_checkbox.Checked && date_before_checkbox.Checked)
                    {
                        search = $"departureTime >= '{afterStr}' AND departureTime <= '{beforeStr}'";
                    }
                    else if (!date_after_checkbox.Checked && date_before_checkbox.Checked)
                    {
                        search = $"departureTime <= '{beforeStr}'";
                    }
                    else if (date_after_checkbox.Checked && !date_before_checkbox.Checked)
                    {
                        search = $"departureTime >= '{afterStr}'";
                    }                    

                    if (newEditTable.Select(search).Length > 0)
                    {
                        newEditTable = newEditTable.Select(search).CopyToDataTable();
                    }
                    else
                    {
                        newEditTable = new DataTable();
                    }
                }
            }
            else
            {
                newEditTable = updateAccountGridViewTable(null, null);
            }

            SBind.DataSource = newEditTable;
            flights_dataview.Columns.Clear();
            flightsTableColumnSetup();
            flights_dataview.DataSource = SBind;
            flights_dataview.Refresh();
        }

        private void singleTransactionsTableColumnSetup()
        {
            manifest_datagridview.DataSource = null;

            manifest_datagridview.AutoGenerateColumns = false;
            manifest_datagridview.ColumnCount = 4;

            manifest_datagridview.Columns[0].Name = "FlightTransactionID";
            manifest_datagridview.Columns[0].HeaderText = "Transaction #";
            manifest_datagridview.Columns[0].DataPropertyName = "FlightTransactionID";
            manifest_datagridview.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            manifest_datagridview.Columns[1].Name = "userID";
            manifest_datagridview.Columns[1].HeaderText = "User Number";
            manifest_datagridview.Columns[1].DataPropertyName = "userID";
            manifest_datagridview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            manifest_datagridview.Columns[2].Name = "FirstName";
            manifest_datagridview.Columns[2].HeaderText = "First Name";
            manifest_datagridview.Columns[2].DataPropertyName = "FirstName";
            manifest_datagridview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            manifest_datagridview.Columns[3].Name = "LastName";
            manifest_datagridview.Columns[3].HeaderText = "Last Name";
            manifest_datagridview.Columns[3].DataPropertyName = "LastName";
            manifest_datagridview.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void flightsTableColumnSetup()
        {
            flights_dataview.DataSource = null;

            flights_dataview.AutoGenerateColumns = false;
            flights_dataview.ColumnCount = 7;

            flights_dataview.Columns[0].Name = "id";
            flights_dataview.Columns[0].HeaderText = "FlightID";
            flights_dataview.Columns[0].DataPropertyName = "id";
            flights_dataview.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            flights_dataview.Columns[1].Name = "originAbv";
            flights_dataview.Columns[1].HeaderText = "Origin";
            flights_dataview.Columns[1].DataPropertyName = "originAbv";
            flights_dataview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            flights_dataview.Columns[2].Name = "destAbv";
            flights_dataview.Columns[2].HeaderText = "Destination";
            flights_dataview.Columns[2].DataPropertyName = "destAbv";
            flights_dataview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            flights_dataview.Columns[3].Name = "departureTime";
            flights_dataview.Columns[3].HeaderText = "Departure (24H)";
            flights_dataview.Columns[3].DataPropertyName = "departureTime";
            flights_dataview.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            flights_dataview.Columns[4].Name = "arrivalTime";
            flights_dataview.Columns[4].HeaderText = "Arrival (24H)";
            flights_dataview.Columns[4].DataPropertyName = "arrivalTime";
            flights_dataview.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            flights_dataview.Columns[5].Name = "cost";
            flights_dataview.Columns[5].HeaderText = "Cost";
            flights_dataview.Columns[5].DataPropertyName = "cost";
            flights_dataview.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            flights_dataview.Columns[6].Name = "currCapacity";
            flights_dataview.Columns[6].HeaderText = "Current Capacity";
            flights_dataview.Columns[6].DataPropertyName = "currCapacity";
            flights_dataview.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        // ===================================================================================================
        // METHODS TO BE MOVED TO FORMDATABASEHELPER LATER ===================================================
        // ===================================================================================================


        // may be same as what already exists in formdatabasehelper
        public static DataTable updateAccountGridViewTable(string orig = null, string dest = null)
        {
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;

            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable newDataTable = new DataTable();

                string requestString;
                int option = 0;
                if (!(orig == null) && (dest == null))
                {
                    requestString = "SELECT * FROM BookedFlights WHERE originAbv LIKE @origin";
                    option = 1;
                }
                else if ((orig == null) && !(dest == null))
                {
                    requestString = "SELECT * FROM BookedFlights WHERE destAbv LIKE @destination";
                    option = 2;
                }
                else if (!(orig == null) && !(dest == null))
                {
                    requestString = "SELECT * FROM BookedFlights WHERE originAbv LIKE @origin AND destAbv LIKE @destination";
                    option = 3;
                }
                else
                {
                    requestString = "SELECT * FROM BookedFlights";
                    option = 4;
                }

                using (SqlCommand sqlCommand = new SqlCommand(requestString, sqlConnection))
                {
                    switch (option)
                    {
                        case 1: // origin only supplied
                            sqlCommand.Parameters.AddWithValue("@origin", orig);

                            break;
                        case 2: // destination only supplied
                            sqlCommand.Parameters.AddWithValue("@destination", dest);

                            break;
                        case 3: // origin and destination supplied
                            sqlCommand.Parameters.AddWithValue("@origin", orig);
                            sqlCommand.Parameters.AddWithValue("@destination", dest);

                            break;
                        case 4: // nothing supplied
                                // nothing happens here
                            break;
                        default:
                            return null;
                            break;
                    }

                    adapter.SelectCommand = sqlCommand;
                    adapter.Fill(newDataTable);

                    return newDataTable;
                }
                return newDataTable;
            }
        }

        public static DataTable updateGridViewTableWithDate(bool dateBefore, bool dateAfter,
            DateTime before = new DateTime(), DateTime after = new DateTime())
        {
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;

            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable newDataTable = new DataTable();

                string requestString = null;
                int option = 0;

                if (dateBefore && dateAfter)
                {
                    requestString = "SELECT * FROM BookedFlights " +
                        "WHERE departureTime >= @after " +
                        "AND departureTime <= @before";
                    option = 1;
                }
                else if (dateBefore && !dateAfter)
                {
                    requestString = "SELECT * FROM BookedFlights " +
                        "WHERE departureTime <= @before";
                    option = 2;
                }
                else if (!dateBefore && dateAfter)
                {
                    requestString = "SELECT * FROM BookedFlights " +
                        "WHERE departureTime >= @after";
                    option = 3;
                }
                else
                {
                    requestString = "SELECT * FROM BookedFlights";
                    option = 4;
                }

                using (SqlCommand sqlCommand = new SqlCommand(requestString, sqlConnection))
                {
                    switch (option)
                    {
                        case 1: // origin only supplied
                            sqlCommand.Parameters.AddWithValue("@after", after);
                            sqlCommand.Parameters.AddWithValue("@before", before);

                            break;
                        case 2: // destination only supplied
                            sqlCommand.Parameters.AddWithValue("@before", before);

                            break;
                        case 3: // origin and destination supplied
                            sqlCommand.Parameters.AddWithValue("@after", after);

                            break;
                        case 4: // nothing supplied
                                // nothing happens here
                            break;
                        default:
                            return null;
                            break;
                    }

                    adapter.SelectCommand = sqlCommand;
                    adapter.Fill(newDataTable);

                    return newDataTable;
                }

                return newDataTable;
            }
        }

        public static DataTable returnFlightInformation(int flightID = -1)
        {
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;

            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable newDataTable = new DataTable();

                string requestString;
                if (flightID == -1)
                {
                    requestString = "SELECT * FROM BookedFlights";
                }
                else
                {
                    requestString = "SELECT * FROM BookedFlights " +
                            "WHERE id = @flightID";
                }

                using (SqlCommand sqlCommand = new SqlCommand(requestString, sqlConnection))
                {
                    if (flightID != -1)
                    {
                        sqlCommand.Parameters.AddWithValue("@flightID", flightID);
                    }

                    adapter.SelectCommand = sqlCommand;
                    adapter.Fill(newDataTable);

                    return newDataTable;
                }

                return newDataTable;
            }
        }

        public static DataTable returnSingleFlightTransactions(int flightID)
        {
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;

            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable newDataTable = new DataTable();

                string requestString = "SELECT * FROM FlightTransactions " +
                        "WHERE BookedFlightID = @flightID";


                using (SqlCommand sqlCommand = new SqlCommand(requestString, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@flightID", flightID);

                    adapter.SelectCommand = sqlCommand;
                    adapter.Fill(newDataTable);

                    return newDataTable;
                }

                return newDataTable;
            }
        }
    }
}
