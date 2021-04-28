using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using DataGrid = System.Windows.Controls.DataGrid;

namespace Air3550
{
    public partial class MarketingLandingPage : Form
    {
        public MarketingLandingPage()
        {
            InitializeComponent();
            FormDatabaseHelper.FillPlaneModelsBox(planesModels_comboBox);
        }

        private void MarketingLandingPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void marketing_datagrid_SelectionChanged(object sender, EventArgs e)
        {
            
                DataGridViewRow currentRow = marketing_datagrid.SelectedRows[0];
                String flightId = "";
                String flight_string = "";
                String plane_type = "";
                String maxCapacity = "";
                String filledSeats = "";
                if (currentRow != null)
                {
                    flightId = currentRow.Cells[0].Value.ToString();
                    flight_string = currentRow.Cells[1].Value.ToString() +
                                    "--> " + currentRow.Cells[2].Value.ToString();

                    plane_type = currentRow.Cells[4].Value.ToString();
                    maxCapacity = currentRow.Cells[5].Value.ToString();
                    filledSeats = currentRow.Cells[6].Value.ToString();
                }

                selFlightValue_textbox.Text = flight_string;
                currPlane_textbox.Text = plane_type;
                curr_maxCapacity_textbox.Text = maxCapacity;
                selFlightId_textbox.Text = flightId;
                filledSeatsValue_textBox.Text = filledSeats;
            
        }


        private void planesModels_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            newCapacityValue_textBox.Text = FormDatabaseHelper.getPlaneCapacity(planesModels_comboBox.SelectedItem.ToString()).ToString();
            //FormDatabaseHelper.updateCapacityBox(planesModels_comboBox.SelectedItem.ToString() , newCapacityValue_label);
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Dispose();
            Login s = new Login();
            s.Visible = true;
        }

        private void MarketingLandingPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'air3550DBDataSet.Flights' table. You can move, or remove it, as needed.
            this.flightsTableAdapter.Fill(this.air3550DBDataSet.Flights);

        }

        private void updatePlane_btn_Click(object sender, EventArgs e)
        {
            String planeModel = "";
            String capacityStr =  newCapacityValue_textBox.Text;

            if (!String.IsNullOrEmpty(capacityStr))
            {
                planeModel = planesModels_comboBox.SelectedItem.ToString();
                int flightId = Int32.Parse(selFlightId_textbox.Text);
                int newCapacity = Int32.Parse(capacityStr);
                int filledSeats = Int32.Parse(filledSeatsValue_textBox.Text);

                //updates in database/flights table
                if (newCapacity > filledSeats)
                {
                    FormDatabaseHelper.updatePlaneInFlightsTable(flightId, planeModel, newCapacity);

                    //update in the data grid view
                    marketing_datagrid.SelectedRows[0].Cells[4].Value = planeModel;
                    marketing_datagrid.SelectedRows[0].Cells[5].Value = newCapacity;
                }
                else
                {
                    Console.WriteLine("Select a plane with higher capacity than current");
                }
            }
            
        }
    }
}
