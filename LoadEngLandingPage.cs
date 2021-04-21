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
            addRoute_groupBox.Hide();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Dispose();
            Login s = new Login();
            s.Visible = true;
        }

        private void addRoute_btn_Click(object sender, EventArgs e)
        {
            editRoute_groupBox.Hide();
            deleteRoute_groupBox.Hide();
            addRoute_groupBox.Show();
            FormDatabaseHelper.fillAirportsAbv(add_origin_comboBox);
            FormDatabaseHelper.fillAirportsAbv(add_dest_comboBox);

        }

        private void editRoute_btn_Click(object sender, EventArgs e)
        {

            addRoute_groupBox.Hide();
            deleteRoute_groupBox.Hide();
            editRoute_groupBox.Show();
            FormDatabaseHelper.fillAirportsAbv(edit_origin_combobox);
            FormDatabaseHelper.fillAirportsAbv(edit_dest_combobox);

        }

        private void deleteRoute_btn_Click(object sender, EventArgs e)
        {
            addRoute_groupBox.Hide();
            deleteRoute_groupBox.Show();
            editRoute_groupBox.Hide();
        }

        private void LoadEngLandingPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'air3550DBDataSet.Flights' table. You can move, or remove it, as needed.
            this.flightsTableAdapter1.Fill(this.air3550DBDataSet.Flights);

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
                                        add_depart_time_DTP.Value.ToString("t"),
                                        add_arrival_time_DTP.Value.ToString("t"),
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
                getArrivalTime();
                calcCost();
                add_status_label.Text = "---";
            }
        }

        private void add_dest_comboBox_TextChanged(object sender, EventArgs e)
        {
            if (add_origin_comboBox.SelectedItem != null && add_dest_comboBox.SelectedItem != null)
            {
                getDistance();
                getArrivalTime();
                calcCost();
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
            getArrivalTime();
            calcCost();
            add_status_label.Text = "---";
        }

        private void getArrivalTime()
        {
            DateTime departTime = add_depart_time_DTP.Value;

            double distance = double.Parse(add_distanceValue_label.Text);
            double airSpeed = 500.0;  //airspeed set by thomas in requirements;
            double taxiTime = 30.0;   //plane to runway + runway to gate set by thomas in requirements;

            double flightTime = (distance / airSpeed) * 60; //time in the air in minutes;
            flightTime = flightTime + taxiTime;             //total flight time in minutes;
            flightTime = flightTime * 60;                   //total time in seconds (seconds needed to add to date/time);

            departTime = departTime.AddSeconds(flightTime);

            add_arrival_time_DTP.Value = departTime;
        }

        private void calcCost()
        {
            double distance = double.Parse(add_distanceValue_label.Text);
            DateTime departure_time = add_depart_time_DTP.Value;
            DateTime arrival_time = add_arrival_time_DTP.Value;

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

            add_cost_label.Text = cost.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
