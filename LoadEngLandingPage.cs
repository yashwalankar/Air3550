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

        private void add_getDist_btn_Click(object sender, EventArgs e)
        {
            
            if(add_origin_comboBox.SelectedItem == null || add_dest_comboBox.SelectedItem == null)
            {
                Console.WriteLine("Either null");
            }
            else
            {
                String origin = add_origin_comboBox.SelectedItem.ToString();
                String dest = add_dest_comboBox.SelectedItem.ToString();
                String distance = String.Format("{0:0.00}", FormDatabaseHelper.getDistance(origin, dest).ToString("0.00"));
                Console.WriteLine(distance);
                add_distanceValue_label.Text = distance;
            }


        }

        private void LoadEngLandingPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'air3550DBDataSet1.Flights' table. You can move, or remove it, as needed.
            this.flightsTableAdapter.Fill(this.air3550DBDataSet1.Flights);

        }

        private void addRoute_submit_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void add_origin_comboBox_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("ItemSelected");
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Dispose();
            Login s = new Login();
            s.Visible = true;
        }
    }
}
