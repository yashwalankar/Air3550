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
            FormDatabaseHelper.FillPlaneModelsBox(add_planetype_comboBox);

        }

        private void editRoute_btn_Click(object sender, EventArgs e)
        {

            addRoute_groupBox.Hide();
            deleteRoute_groupBox.Hide();
            editRoute_groupBox.Show();


        }

        private void deleteRoute_btn_Click(object sender, EventArgs e)
        {
            addRoute_groupBox.Hide();
            deleteRoute_groupBox.Show();
            editRoute_groupBox.Hide();
        }

        private void LoadEngLandingPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'air3550DBDataSet1.Flights' table. You can move, or remove it, as needed.
            this.flightsTableAdapter.Fill(this.air3550DBDataSet1.Flights);

        }

        private void addRoute_submit_btn_Click(object sender, EventArgs e)
        {
            if(add_origin_comboBox.SelectedItem != null 
                && add_dest_comboBox.SelectedItem != null
                && add_planetype_comboBox.SelectedItem != null)
            {
                flight newFlight = new flight();
                newFlight.createFlight(add_origin_comboBox.Text,
                                        add_dest_comboBox.Text,
                                        add_depart_time_DTP.Value.ToString(),
                                        arrival_time_DTP.Value.ToString(),
                                        add_planetype_comboBox.Text,
                                        0);

                FormDatabaseHelper.uploadFlight(newFlight);
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
            }
        }
        
        private void add_dest_comboBox_TextChanged(object sender, EventArgs e)
        {
            if (add_origin_comboBox.SelectedItem != null && add_dest_comboBox.SelectedItem != null)
            {
                getDistance();
                getArrivalTime();
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

            arrival_time_DTP.Value = departTime;
        }
    }
}
