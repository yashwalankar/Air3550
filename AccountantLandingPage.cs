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

            FormDatabaseHelper.fillAirportsAbv(origin_combobox);
            FormDatabaseHelper.fillAirportsAbv(dest_combobox);

            tools_groupbox.Show();
            singleflight_report_groupbox.Hide();
            fullReport_groupbox.Hide();
        }

        private void AccountantLandingPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void logout_button_Click(object sender, MouseEventArgs e)
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
        // Single Flight Report Functionality ==============================================================
        // =================================================================================================

        private void single_report_button_Click(object sender, EventArgs e)
        {
            int flightID = int.Parse(flights_dataview.CurrentRow.Cells["id"].Value.ToString());

            DataTable bookedFlightInfo = returnFlightInformation(flightID);
            DataTable flightTransactions = returnSingleFlightTransactions(flightID);

            fillSingleReport(bookedFlightInfo, flightTransactions);

            tools_groupbox.Hide();
            singleflight_report_groupbox.Show();
        }

        private void close_single_report_button_Click(object sender, EventArgs e)
        {
            tools_groupbox.Show();
            singleflight_report_groupbox.Hide();
        }

        private void fillSingleReport(DataTable flight, DataTable transactions)
        {
            single_flightID_label.Text      = flight.Rows[0].Field<int>("id").ToString();
            single_originCode_label.Text    = flight.Rows[0].Field<string>("originAbv");
            single_destCode_label.Text      = flight.Rows[0].Field<string>("destAbv");
            single_depDate_label.Text       = flight.Rows[0].Field<DateTime>("departureTime").ToString();
            single_arrivalDate_label.Text   = flight.Rows[0].Field<DateTime>("arrivalTime").ToString();

            double maxCap  = flight.Rows[0].Field<int>("maxCapacity");
            double currCap = flight.Rows[0].Field<int>("currCapacity");
            double percCap = (currCap / maxCap) * 100.00;
            percCap = Math.Round(percCap,2);

            single_max_cap_label.Text = maxCap.ToString();
            single_curr_cap_label.Text = currCap.ToString();
            single_percFill_label.Text = percCap.ToString();

            // calculate revenue from card payments
            double revenue = findRevenue(transactions, 1);
            single_cardRev_label.Text = revenue.ToString();

            // calculate revenue from reward reimbursement
            revenue = findRevenue(transactions, 2);
            single_pointRev_label.Text = revenue.ToString();

            BindingSource SBind = new BindingSource();
            SBind.DataSource = transactions;
            single_transactions_datagridview.Columns.Clear();
            singleTransactionsTableColumnSetup();
            single_transactions_datagridview.DataSource = SBind;
            single_transactions_datagridview.Refresh();
        }

        // =================================================================================================
        // Full Revenue Report Functionality ===============================================================
        // =================================================================================================

        private void generate_submit_button_Click(object sender, EventArgs e)
        { 
            fillFullReport();

            tools_groupbox.Hide();
            fullReport_groupbox.Show();
        }

        private void full_report_close_button_Click(object sender, EventArgs e)
        {
            tools_groupbox.Show();
            fullReport_groupbox.Hide();
        }

        private void fillFullReport()
        {
            DataTable allBookedFlights = returnFlightInformation();
            allBookedFlights.Columns.Add("percCapacity", typeof(double));
            allBookedFlights.Columns.Add("cardRev", typeof(double));
            allBookedFlights.Columns.Add("rewardRev", typeof(double));

            int count = allBookedFlights.Rows.Count;
            full_flightCount_label.Text = count.ToString();

            int flightID;
            int currentRow = 0;
            double cardRev = 0.00;
            double rewardRev = 0.00;
            foreach (DataRow row in allBookedFlights.Rows)
            {
                flightID = row.Field<int>("id");

                DataTable transactions = returnSingleFlightTransactions(flightID);

                double currentCardRev = findRevenue(transactions, 1);
                currentCardRev = Math.Round(currentCardRev, 2);
                double currentRewardRev = findRevenue(transactions, 2);

                allBookedFlights.Rows[currentRow].SetField<double>("cardRev",currentCardRev);
                allBookedFlights.Rows[currentRow].SetField<double>("rewardRev", currentRewardRev);

                cardRev = cardRev + currentCardRev;
                rewardRev = rewardRev + currentRewardRev;

                double maxCap = row.Field<int>("maxCapacity");
                double currCap = row.Field<int>("currCapacity");
                double percCap = (currCap / maxCap) * 100.00;
                percCap = Math.Round(percCap, 2);

                allBookedFlights.Rows[currentRow].SetField<double>("percCapacity", percCap);

                currentRow++;
            }
            full_cardRev_label.Text = cardRev.ToString();
            full_pointRev_label.Text = rewardRev.ToString();

            BindingSource SBind = new BindingSource();
            SBind.DataSource = allBookedFlights;
            full_report_datagridview.Columns.Clear();
            fullTransactionsTableColumnSetup();
            full_report_datagridview.DataSource = SBind;
            full_report_datagridview.Refresh();
        }

        // =================================================================================================
        // General and Helper Functionality ================================================================
        // =================================================================================================
        private static double findRevenue(DataTable table, int payType)
        {
            DataTable transactions = new DataTable();
            string search = $"PaymentType = {payType}";
            if (table.Select(search).Length > 0)
            {
                transactions = table.Select(search).CopyToDataTable();
            }
            double revenue = 0;
            foreach (DataRow row in transactions.Rows)
            {
                revenue = revenue + row.Field<double>("Cost");
            }
            return revenue;
        }

        private void updateTable()
        {
            DataTable newEditTable = new DataTable();
            BindingSource SBind = new BindingSource();

            bool location = false, date = false;
            location = origin_dest_checkbox.Checked;
            date = date_checkbox.Checked;

            bool multiPassTableSort = false;

            if (location && date) multiPassTableSort = true;

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

        private void singleTransactionsTableColumnSetup()
        {
            single_transactions_datagridview.DataSource = null;

            single_transactions_datagridview.AutoGenerateColumns = false;
            single_transactions_datagridview.ColumnCount = 6;

            single_transactions_datagridview.Columns[0].Name = "FlightTransactionID";
            single_transactions_datagridview.Columns[0].HeaderText = "Transaction #";
            single_transactions_datagridview.Columns[0].DataPropertyName = "FlightTransactionID";
            single_transactions_datagridview.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            single_transactions_datagridview.Columns[1].Name = "FirstName";
            single_transactions_datagridview.Columns[1].HeaderText = "First Name";
            single_transactions_datagridview.Columns[1].DataPropertyName = "FirstName";
            single_transactions_datagridview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            single_transactions_datagridview.Columns[2].Name = "LastName";
            single_transactions_datagridview.Columns[2].HeaderText = "Last Name";
            single_transactions_datagridview.Columns[2].DataPropertyName = "LastName";
            single_transactions_datagridview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            single_transactions_datagridview.Columns[3].Name = "CardNumber";
            single_transactions_datagridview.Columns[3].HeaderText = "Card Number";
            single_transactions_datagridview.Columns[3].DataPropertyName = "CardNumber";
            single_transactions_datagridview.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            single_transactions_datagridview.Columns[4].Name = "PaymentType";
            single_transactions_datagridview.Columns[4].HeaderText = "Payment\n1-Card 2-Reward";
            single_transactions_datagridview.Columns[4].DataPropertyName = "PaymentType";
            single_transactions_datagridview.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            single_transactions_datagridview.Columns[5].Name = "Cost";
            single_transactions_datagridview.Columns[5].HeaderText = "PaymentAmount";
            single_transactions_datagridview.Columns[5].DataPropertyName = "Cost";
            single_transactions_datagridview.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void fullTransactionsTableColumnSetup()
        {
            full_report_datagridview.DataSource = null;

            full_report_datagridview.AutoGenerateColumns = false;
            full_report_datagridview.ColumnCount = 7;

            //full_report_datagridview.Columns[0].Name = "id";
            //full_report_datagridview.Columns[0].HeaderText = "Flight ID";
            //full_report_datagridview.Columns[0].DataPropertyName = "id";
            //full_report_datagridview.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            full_report_datagridview.Columns[0].Name = "originAbv";
            full_report_datagridview.Columns[0].HeaderText = "Origin";
            full_report_datagridview.Columns[0].DataPropertyName = "originAbv";
            full_report_datagridview.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            full_report_datagridview.Columns[1].Name = "destAbv";
            full_report_datagridview.Columns[1].HeaderText = "Destination";
            full_report_datagridview.Columns[1].DataPropertyName = "destAbv";
            full_report_datagridview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            full_report_datagridview.Columns[2].Name = "departureTime";
            full_report_datagridview.Columns[2].HeaderText = "Departure";
            full_report_datagridview.Columns[2].DataPropertyName = "departureTime";
            full_report_datagridview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            full_report_datagridview.Columns[3].Name = "arrivalTime";
            full_report_datagridview.Columns[3].HeaderText = "Arrival";
            full_report_datagridview.Columns[3].DataPropertyName = "arrivalTime";
            full_report_datagridview.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            full_report_datagridview.Columns[4].Name = "cardRev";
            full_report_datagridview.Columns[4].HeaderText = "Card Revenue";
            full_report_datagridview.Columns[4].DataPropertyName = "cardRev";
            full_report_datagridview.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            full_report_datagridview.Columns[5].Name = "rewardRev";
            full_report_datagridview.Columns[5].HeaderText = "Point Revenue";
            full_report_datagridview.Columns[5].DataPropertyName = "rewardRev";
            full_report_datagridview.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            full_report_datagridview.Columns[6].Name = "percCapacity";
            full_report_datagridview.Columns[6].HeaderText = "Flight Fill %";
            full_report_datagridview.Columns[6].DataPropertyName = "percCapacity";
            full_report_datagridview.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
                if (flightID == -1) {
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
