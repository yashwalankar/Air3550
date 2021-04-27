using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Air3550
{
    public partial class AccountantLandingPage : Form
    {
        public AccountantLandingPage()
        {
            InitializeComponent();

            DataTable newEditTable = updateAccountGridViewTable();
            BindingSource SBind = new BindingSource();
            SBind.DataSource = newEditTable;
            flightsTableColumnSetup();
            flights_dataview.DataSource = SBind;
            flights_dataview.Refresh();
        }

        private void AccountantLandingPage_FormClosing(object sender, FormClosingEventArgs e)
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

        private void origin_combobox_TextChanged(object sender, EventArgs e)
        {
            updateTable();
        }

        private void dest_combobox_TextChanged(object sender, EventArgs e)
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
            }
            else
            {
                afterDate_DTP.Enabled = false;
                beforeDate_DTP.Enabled = false;
            }
        }

        // =================================================================================================
        // Time Based Search Functionality =================================================================
        // =================================================================================================

        private void time_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = time_checkbox.Checked;

            if (isChecked == true)
            {
                afterTime_DTP.Enabled = true;
                beforeTime_DTP.Enabled = true;
            }
            else
            {
                afterTime_DTP.Enabled = false;
                beforeTime_DTP.Enabled = false;
            }
        }

        // =================================================================================================
        // General and Helper Functionality ================================================================
        // =================================================================================================
        private void updateTable()
        {
            DataTable newEditTable;
            BindingSource SBind = new BindingSource();

            bool location = false, date = false, time = false;
            location = origin_dest_checkbox.Checked;
            date = date_checkbox.Checked;
            time = time_checkbox.Checked;

            bool multiPassTableSort = false;

            if (location && (date || time)) multiPassTableSort = true;
            if (date && (location || time)) multiPassTableSort = true;
            if (time && (location || date)) multiPassTableSort = true;

            if (location && !multiPassTableSort) {
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
                //
            }
            else if (time && !multiPassTableSort)
            {
                //
            }
            else
            {
                newEditTable = updateAccountGridViewTable(null, null);
            }

            //SBind.DataSource = newEditTable;
            flights_dataview.Columns.Clear();
            flightsTableColumnSetup();
            flights_dataview.DataSource = SBind;
            flights_dataview.Refresh();
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
        public static DataTable updateAccountGridViewTable(string orig = null, string dest = null, 
            DateTime after = new DateTime(), DateTime before = new DateTime())
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
            }
        }
    }
}
