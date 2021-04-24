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
    public partial class LoadEngLandingPage : Form
    {
        public LoadEngLandingPage()
        {
            InitializeComponent();
            editRoute_groupBox.Hide();
            deleteRoute_groupBox.Hide();
            addRoute_groupBox.Show();
            FormDatabaseHelper.fillAirportsAbv(add_origin_comboBox);
            FormDatabaseHelper.fillAirportsAbv(add_dest_comboBox);
        }

        private void LoadEngLandingPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'air3550DBDataSet.Flights' table. You can move, or remove it, as needed.
            //this.flightsTableAdapter1.Fill(this.air3550DBDataSet.Flights);

        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Dispose();
            Login s = new Login();
            s.Visible = true;
        }

        // ==================================================================================
        // Add Route Group Methods ==========================================================
        // ==================================================================================
        private void addRoute_btn_Click(object sender, EventArgs e)
        {
            editRoute_groupBox.Hide();
            deleteRoute_groupBox.Hide();
            addRoute_groupBox.Show();
            FormDatabaseHelper.fillAirportsAbv(add_origin_comboBox);
            FormDatabaseHelper.fillAirportsAbv(add_dest_comboBox);

        }

        private void addRoute_submit_btn_Click(object sender, EventArgs e)
        {
            if (add_origin_comboBox.SelectedItem != null
                && add_dest_comboBox.SelectedItem != null)
            {
                string defaultPlane = "Boeing 737";
                int maxCap = FormDatabaseHelper.getPlaneCapacity(defaultPlane);

                flight newFlight = new flight();
                newFlight.createFlight(add_origin_comboBox.Text,
                                        add_dest_comboBox.Text,
                                        add_depart_time_DTP.Value,
                                        add_arrival_time_DTP.Value,
                                        defaultPlane,
                                        double.Parse(add_cost_label.Text),
                                        maxCap,
                                        0);

                FormDatabaseHelper.uploadFlight(newFlight);

                add_status_label.Text = "Flight added successfully";
            }
            else
            {
                //error code here
            }
        }

        private void add_origin_comboBox_TextChanged(object sender, EventArgs e)
        {
            if (add_origin_comboBox.SelectedItem != null && add_dest_comboBox.SelectedItem != null)
            {
                getDistance();

                DateTime depart_time = add_depart_time_DTP.Value;

                double distance = double.Parse(add_distanceValue_label.Text);

                DateTime arrival_time = getArrivalTime(depart_time, distance);
                add_arrival_time_DTP.Value = arrival_time;

                add_cost_label.Text = calcCost(distance, depart_time, arrival_time).ToString();
                add_status_label.Text = "---";
            }
        }

        private void add_dest_comboBox_TextChanged(object sender, EventArgs e)
        {
            if (add_origin_comboBox.SelectedItem != null && add_dest_comboBox.SelectedItem != null)
            {
                getDistance();

                DateTime depart_time = add_depart_time_DTP.Value;

                double distance = double.Parse(add_distanceValue_label.Text);

                DateTime arrival_time = getArrivalTime(depart_time, distance);
                add_arrival_time_DTP.Value = arrival_time;

                add_cost_label.Text = calcCost(distance, depart_time, arrival_time).ToString();
                add_status_label.Text = "---";
            }
        }

        private void getDistance()
        {
            if (add_origin_comboBox.SelectedItem == null || add_dest_comboBox.SelectedItem == null)
            {
                // error code here
            }
            else
            {
                String origin = add_origin_comboBox.SelectedItem.ToString();
                String dest = add_dest_comboBox.SelectedItem.ToString();
                String distance = String.Format("{0:0.00}", FormDatabaseHelper.getDistance(origin, dest).ToString("0.00"));
                add_distanceValue_label.Text = distance;
            }
        }

        private void add_depart_time_DTP_ValueChanged(object sender, EventArgs e)
        {
            DateTime depart_time = add_depart_time_DTP.Value;

            double distance = double.Parse(add_distanceValue_label.Text);

            DateTime arrival_time = getArrivalTime(depart_time, distance);
            add_arrival_time_DTP.Value = arrival_time;

            add_cost_label.Text = calcCost(distance, depart_time, arrival_time).ToString();
            add_status_label.Text = "---";
        }

        // ==================================================================================
        // Edit Route Group Methods and Variables ===========================================
        // ==================================================================================
        string originAbv;
        string destinationAbv;
        DateTime departTime;
        DateTime arrivalTime;
        double cost;

        private void editRoute_btn_Click(object sender, EventArgs e)
        {

            addRoute_groupBox.Hide();
            deleteRoute_groupBox.Hide();
            editRoute_groupBox.Show();
            FormDatabaseHelper.fillAirportsAbv(edit_origin_combobox);
            FormDatabaseHelper.fillAirportsAbv(edit_dest_combobox);

            DataTable newEditTable = FormDatabaseHelper.updateEditGridViewTable(null, null);
            BindingSource SBind = new BindingSource();
            SBind.DataSource = newEditTable;
            editTableColumnSetup();
            edit_flights_dataview.DataSource = SBind;
            edit_flights_dataview.Refresh();

        }

        private void edit_origin_combobox_TextChanged(object sender, EventArgs e)
        {
            string origin = edit_origin_combobox.Text;
            DataTable newEditTable;
            BindingSource SBind = new BindingSource();

            if (edit_dest_combobox.SelectedItem != null)
            {
                string destination = edit_dest_combobox.Text;
                newEditTable = FormDatabaseHelper.updateEditGridViewTable(origin, destination);
            }
            else
            {
                newEditTable = FormDatabaseHelper.updateEditGridViewTable(origin, null);
            }

            SBind.DataSource = newEditTable;
            edit_flights_dataview.Columns.Clear();
            editTableColumnSetup();
            edit_flights_dataview.DataSource = SBind;
            edit_flights_dataview.Refresh();

        }

        private void edit_dest_combobox_TextChanged(object sender, EventArgs e)
        {
            string destination = edit_dest_combobox.Text;
            DataTable newEditTable;
            BindingSource SBind = new BindingSource();

            if (edit_origin_combobox.SelectedItem != null)
            { 
                string origin = edit_origin_combobox.Text;
                newEditTable = FormDatabaseHelper.updateEditGridViewTable(origin, destination);
            }
            else
            {
                newEditTable = FormDatabaseHelper.updateEditGridViewTable(null, destination);
            }

            SBind.DataSource = newEditTable;
            edit_flights_dataview.Columns.Clear();
            editTableColumnSetup();
            edit_flights_dataview.DataSource = SBind;
            edit_flights_dataview.Refresh();
        }

        private void edit_flights_dataview_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = this.edit_flights_dataview.CurrentRow;

            if (row != null)
            {
                this.originAbv = row.Cells["originAbv"].Value.ToString();
                
                this.destinationAbv = row.Cells["destAbv"].Value.ToString();
                
                this.departTime = DateTime.Parse(row.Cells["departureTime"].Value.ToString());
                DateTime currentDate = DateTime.Now;
                this.departTime = currentDate.Date + this.departTime.TimeOfDay;

                this.arrivalTime = DateTime.Parse(row.Cells["arrivalTime"].Value.ToString());
                this.arrivalTime = currentDate.Date + this.arrivalTime.TimeOfDay;
                
                this.cost = double.Parse(row.Cells["cost"].Value.ToString());

                edit_depart_time_DTP.Value = this.departTime;
                edit_arrival_time_DTP.Value = this.arrivalTime;
            }
        }

        private void edit_depart_time_DTP_ValueChanged(object sender, EventArgs e)
        {
            double distance = double.Parse(edit_flights_dataview.CurrentRow.Cells["distance"].Value.ToString());
            DateTime newarrival = getArrivalTime(edit_depart_time_DTP.Value, distance);
            DateTime corrected = DateTime.Now;
            corrected = corrected.Date + newarrival.TimeOfDay;

            edit_arrival_time_DTP.Value = corrected;

            double cost = calcCost(distance, this.departTime, corrected);

            edit_costValue_label.Text = cost.ToString();
        }

        private void edit_submit_btn_Click(object sender, EventArgs e)
        {
            int flightID = int.Parse(edit_flights_dataview.CurrentRow.Cells["id"].Value.ToString());
            double cost = double.Parse(edit_costValue_label.Text);
            DateTime arrival_time = edit_arrival_time_DTP.Value;
            DateTime departure_time = edit_depart_time_DTP.Value;
            FormDatabaseHelper.updateTimesInFlightsTable(flightID,arrival_time,departure_time,cost);

            string destination = edit_dest_combobox.Text;
            string origin = edit_origin_combobox.Text;
            DataTable newEditTable;
            BindingSource SBind = new BindingSource();

            if ((edit_origin_combobox.SelectedItem != null) && (edit_dest_combobox.SelectedItem != null))
            {
                newEditTable = FormDatabaseHelper.updateEditGridViewTable(origin, destination);
            }
            else if ((edit_origin_combobox.SelectedItem == null) && (edit_dest_combobox.SelectedItem != null))
            {
                newEditTable = FormDatabaseHelper.updateEditGridViewTable(destination, null);
            }
            else if ((edit_origin_combobox.SelectedItem != null) && (edit_dest_combobox.SelectedItem == null))
            {
                newEditTable = FormDatabaseHelper.updateEditGridViewTable(null, origin);
            }
            else
            {
                newEditTable = FormDatabaseHelper.updateEditGridViewTable(null, null);
            }

            SBind.DataSource = newEditTable;
            edit_flights_dataview.Columns.Clear();
            editTableColumnSetup();
            edit_flights_dataview.DataSource = SBind;
            edit_flights_dataview.Refresh();
        }

        private void edit_clearSort_button_Click(object sender, EventArgs e)
        {
            edit_origin_combobox.SelectedItem = null;
            edit_dest_combobox.SelectedItem = null;

            DataTable newEditTable = FormDatabaseHelper.updateEditGridViewTable(null, null);
            BindingSource SBind = new BindingSource();
            SBind.DataSource = newEditTable;
            editTableColumnSetup();
            edit_flights_dataview.DataSource = SBind;
            edit_flights_dataview.Refresh();
        }

        private void editTableColumnSetup()
        {
            edit_flights_dataview.DataSource = null;

            edit_flights_dataview.AutoGenerateColumns = false;
            edit_flights_dataview.ColumnCount = 7;

            edit_flights_dataview.Columns[0].Name = "id";
            edit_flights_dataview.Columns[0].HeaderText = "FlightID";
            edit_flights_dataview.Columns[0].DataPropertyName = "id";
            edit_flights_dataview.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            edit_flights_dataview.Columns[1].Name = "originAbv";
            edit_flights_dataview.Columns[1].HeaderText = "Origin";
            edit_flights_dataview.Columns[1].DataPropertyName = "originAbv";
            edit_flights_dataview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            edit_flights_dataview.Columns[2].Name = "destAbv";
            edit_flights_dataview.Columns[2].HeaderText = "Destination";
            edit_flights_dataview.Columns[2].DataPropertyName = "destAbv";
            edit_flights_dataview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            edit_flights_dataview.Columns[3].Name = "departureTime";
            edit_flights_dataview.Columns[3].HeaderText = "Departure (24H)";
            edit_flights_dataview.Columns[3].DataPropertyName = "departureTime";
            edit_flights_dataview.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            edit_flights_dataview.Columns[4].Name = "arrivalTime";
            edit_flights_dataview.Columns[4].HeaderText = "Arrival (24H)";
            edit_flights_dataview.Columns[4].DataPropertyName = "arrivalTime";
            edit_flights_dataview.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            edit_flights_dataview.Columns[5].Name = "distance";
            edit_flights_dataview.Columns[5].HeaderText = "distance";
            edit_flights_dataview.Columns[5].DataPropertyName = "distance";
            edit_flights_dataview.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            edit_flights_dataview.Columns[6].Name = "cost";
            edit_flights_dataview.Columns[6].HeaderText = "Cost";
            edit_flights_dataview.Columns[6].DataPropertyName = "cost";
            edit_flights_dataview.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        // ==================================================================================
        // Delete Route Group Methods and Variables =========================================
        // ==================================================================================
        private void deleteRoute_btn_Click(object sender, EventArgs e)
        {
            addRoute_groupBox.Hide();
            deleteRoute_groupBox.Show();
            editRoute_groupBox.Hide();
            FormDatabaseHelper.fillAirportsAbv(del_origin_combobox);
            FormDatabaseHelper.fillAirportsAbv(del_destination_combobox);

            DataTable newEditTable = FormDatabaseHelper.updateEditGridViewTable(null, null);
            BindingSource SBind = new BindingSource();
            SBind.DataSource = newEditTable;
            deleteTableColumnSetup();
            del_flights_datagridview.DataSource = SBind;
            del_flights_datagridview.Refresh();
        }

        private void del_origin_combobox_TextChanged(object sender, EventArgs e)
        {
            string origin = del_origin_combobox.Text;
            DataTable newEditTable;
            BindingSource SBind = new BindingSource();

            if (del_destination_combobox.SelectedItem != null)
            {
                string destination = del_destination_combobox.Text;
                newEditTable = FormDatabaseHelper.updateEditGridViewTable(origin, destination);
            }
            else
            {
                newEditTable = FormDatabaseHelper.updateEditGridViewTable(origin, null);
            }

            SBind.DataSource = newEditTable;
            del_flights_datagridview.Columns.Clear();
            deleteTableColumnSetup();
            del_flights_datagridview.DataSource = SBind;
            del_flights_datagridview.Refresh();
        }

        private void del_destination_combobox_TextChanged(object sender, EventArgs e)
        {
            string destination = del_destination_combobox.Text;
            DataTable newEditTable;
            BindingSource SBind = new BindingSource();
            
            if (del_origin_combobox.SelectedItem != null)
            {
                string origin = del_origin_combobox.Text;
                newEditTable = FormDatabaseHelper.updateEditGridViewTable(origin, destination);
            }
            else
            {
                newEditTable = FormDatabaseHelper.updateEditGridViewTable(null, destination);
            }

            SBind.DataSource = newEditTable;
            del_flights_datagridview.Columns.Clear();
            deleteTableColumnSetup();
            del_flights_datagridview.DataSource = SBind;
            del_flights_datagridview.Refresh();
        }

        private void del_flights_datagridview_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = this.del_flights_datagridview.CurrentRow;

            if (row != null)
            {
                string flightIDString = row.Cells["id"].Value.ToString();
                del_flightidvalue_label.Text = flightIDString;
            }
        }

        private void del_submit_button_Click(object sender, EventArgs e)
        {
            int id = int.Parse(del_flightidvalue_label.Text);
            FormDatabaseHelper.removeFlightFromRoutes(id);
            
            string origin = del_destination_combobox.Text;
            string destination = del_destination_combobox.Text;
            DataTable newEditTable;
            BindingSource SBind = new BindingSource();

            if ((del_origin_combobox.SelectedItem != null) && (del_destination_combobox.SelectedItem != null))
            {
                newEditTable = FormDatabaseHelper.updateEditGridViewTable(origin, destination);
            }
            else if ((del_origin_combobox.SelectedItem != null) && (del_destination_combobox.SelectedItem == null))
            {
                newEditTable = FormDatabaseHelper.updateEditGridViewTable(origin, null);
            }
            else if ((del_origin_combobox.SelectedItem == null) && (del_destination_combobox.SelectedItem != null))
            {
                newEditTable = FormDatabaseHelper.updateEditGridViewTable(null, destination);
            }
            else
            {
                newEditTable = FormDatabaseHelper.updateEditGridViewTable(null, null);
            }

            SBind.DataSource = newEditTable;
            del_flights_datagridview.Columns.Clear();
            deleteTableColumnSetup();
            del_flights_datagridview.DataSource = SBind;
            del_flights_datagridview.Refresh();
        }

        private void del_clearSort_button_Click(object sender, EventArgs e)
        {
            del_origin_combobox.SelectedItem = null;
            del_destination_combobox.SelectedItem = null;

            DataTable newEditTable = FormDatabaseHelper.updateEditGridViewTable(null, null);
            BindingSource SBind = new BindingSource();
            SBind.DataSource = newEditTable;
            deleteTableColumnSetup();
            del_flights_datagridview.DataSource = SBind;
            del_flights_datagridview.Refresh();
        }

        private void deleteTableColumnSetup()
        {
            del_flights_datagridview.DataSource = null;

            del_flights_datagridview.AutoGenerateColumns = false;
            del_flights_datagridview.ColumnCount = 6;

            del_flights_datagridview.Columns[0].Name = "id";
            del_flights_datagridview.Columns[0].HeaderText = "FlightID";
            del_flights_datagridview.Columns[0].DataPropertyName = "id";
            del_flights_datagridview.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            del_flights_datagridview.Columns[1].Name = "originAbv";
            del_flights_datagridview.Columns[1].HeaderText = "Origin";
            del_flights_datagridview.Columns[1].DataPropertyName = "originAbv";
            del_flights_datagridview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            del_flights_datagridview.Columns[2].Name = "destAbv";
            del_flights_datagridview.Columns[2].HeaderText = "Destination";
            del_flights_datagridview.Columns[2].DataPropertyName = "destAbv";
            del_flights_datagridview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            del_flights_datagridview.Columns[3].Name = "departureTime";
            del_flights_datagridview.Columns[3].HeaderText = "Departure (24H)";
            del_flights_datagridview.Columns[3].DataPropertyName = "departureTime";
            del_flights_datagridview.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            del_flights_datagridview.Columns[4].Name = "arrivalTime";
            del_flights_datagridview.Columns[4].HeaderText = "Arrival (24H)";
            del_flights_datagridview.Columns[4].DataPropertyName = "arrivalTime";
            del_flights_datagridview.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            del_flights_datagridview.Columns[5].Name = "cost";
            del_flights_datagridview.Columns[5].HeaderText = "Cost";
            del_flights_datagridview.Columns[5].DataPropertyName = "cost";
            del_flights_datagridview.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        // ==================================================================================
        // Shared Methods ===================================================================
        // ==================================================================================
        private DateTime getArrivalTime(DateTime departTime, double distance)
        {
            double airSpeed = 500.0;  //airspeed set by thomas in requirements;
            double taxiTime = 30.0;   //plane to runway + runway to gate set by thomas in requirements;

            double flightTime = (distance / airSpeed) * 60; //time in the air in minutes;
            flightTime = flightTime + taxiTime;             //total flight time in minutes;
            flightTime = flightTime * 60;                   //total time in seconds (seconds needed to add to date/time);

            departTime = departTime.AddSeconds(flightTime);

            return departTime;
        }

        private double calcCost(double distance, DateTime departure_time, DateTime arrival_time)
        {
            double discount = 1.0;
            DateTime dt8AM = new DateTime(departure_time.Year, departure_time.Month, departure_time.Day, 8, 0, 0);
            DateTime dt7PM = new DateTime(arrival_time.Year, arrival_time.Month, arrival_time.Day, 19, 0, 0);
            DateTime dt5AMdept = new DateTime(departure_time.Year, departure_time.Month, departure_time.Day, 5, 0, 0);
            DateTime dt5AMarriv = new DateTime(arrival_time.Year, arrival_time.Month, arrival_time.Day, 5, 0, 0);

            if ((departure_time < dt8AM) || (arrival_time > dt7PM))//set it to .9 if departure is before 800 or if arrival is after 1900
            {
                discount = 0.9;
            }
            if ((departure_time < dt5AMdept) || (arrival_time < dt5AMarriv))//set it to .8 if either is less than 500
            {
                discount = 0.8;
            }

            double cost = (50.0 + 0.12 * distance) * discount;

            cost = Math.Round(cost, 2);

            return cost;
        }
    }
}
