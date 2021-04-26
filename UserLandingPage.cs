using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air3550
{
    public partial class UserLandingPage : Form
    {
        public UserLandingPage(User user)
        {
            InitializeComponent();
            welcome_label.Text = "Welcome, " + user.firstName + " " + user.lastName;
            userId_value_label.Text = user.id.ToString();
            rewardBalance_value_label.Text = user.rewardBalance.ToString();

            FormDatabaseHelper.fillAirportsCity(origin_comboBox);
            FormDatabaseHelper.fillAirportsCity(destination_comboBox);

            bookFlights_groupBox.Hide();
            upcomingFlights_groupBox.Hide();
            pastFlights_groupBox.Hide();

            oneway_groupBox.Hide();
            ShowReturnComponents(false);
        }
        
        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Dispose();
            Login s = new Login();
            s.Visible = true;
        }

        private void bookFlights_btn_Click(object sender, EventArgs e)
        {
            
            upcomingFlights_groupBox.Hide();
            pastFlights_groupBox.Hide();
            bookFlights_groupBox.Show();
        }

        

        private void pastFlights_btn_Click(object sender, EventArgs e)
        {
            bookFlights_groupBox.Hide();
            upcomingFlights_groupBox.Hide();
            pastFlights_groupBox.Show();
        }

        private void upComingFlights_btn_Click(object sender, EventArgs e)
        {
            bookFlights_groupBox.Hide();
            pastFlights_groupBox.Hide();
            upcomingFlights_groupBox.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bookFlights_groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void return_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (return_rBtn.Checked == true)
            {
                ShowReturnComponents(true);
                
            }
            else
            {
                ShowReturnComponents(false);
                
            }
        }

        private void oneWay_rBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (oneWay_rBtn.Checked == true)
            {
                ShowReturnComponents(false);
            }
            else
            {
                ShowReturnComponents(true);
            }
        }

        private void ShowReturnComponents(bool show)
        {
            if (show)
            {
                returnDate_label.Show();
                returnDate_dtp.Show();
                arrow_label.Text = "<---->";

                return_groupBox.Show();

            }
            else
            {
                returnDate_label.Hide();
                returnDate_dtp.Hide();

                arrow_label.Text = " ---->";

                return_groupBox.Hide();
            }

        }

        private void checkFlights_btn_Click(object sender, EventArgs e)
        {

            //check if origin and dest are selected
            if (origin_comboBox.SelectedItem != null && destination_comboBox.SelectedItem != null)
            {

                DateTime currSysTime = currSysTime_DTP.Value;
                DateTime deptTime = deptDate_dtp.Value;
                bool oneWay = oneWay_rBtn.Checked;
                bool returnBooking = return_rBtn.Checked;

               // String originAbv = origin_comboBox.SelectedItem.ToString();
               // String destAbv = destination_comboBox.SelectedItem.ToString();

               // Console.WriteLine(originAbv);
               // Console.WriteLine(destAbv);

                String originAbv =  FormDatabaseHelper.getAirportAbvFromCity(origin_comboBox.SelectedItem.ToString());
                String destAbv = FormDatabaseHelper.getAirportAbvFromCity(destination_comboBox.SelectedItem.ToString());

                //check if origin and destination are not same
                if (originAbv != destAbv)
                {
                    //Check if flight departure is within 6 months of current time
                    if (deptTime <= currSysTime.AddDays(60))
                    {
                        //find flight 
                        oneway_datagridview.DataSource = FormDatabaseHelper.getAvailableFlights(originAbv, destAbv, deptTime);




                    }
                    else
                    {
                        Console.WriteLine("Depature date should be within 6 months");
                    }
                }
                else
                {
                    Console.WriteLine("origin and dest cannot be same");
                }
            }
            else
            {
                Console.WriteLine("origin and dest not set");
            }
        }

        private void showFlights_btn_Click(object sender, EventArgs e)
        {
            if(origin_comboBox.SelectedItem != null && destination_comboBox.SelectedItem != null)
            {
                String originCity  = origin_comboBox.SelectedItem.ToString();
                String destCity = destination_comboBox.SelectedItem.ToString();

                String originAbv = FormDatabaseHelper.getAirportAbvFromCity(originCity);
                String destAbv = FormDatabaseHelper.getAirportAbvFromCity(destCity);

                DateTime currSysTime = currSysTime_DTP.Value;
                DateTime deptDate = deptDate_dtp.Value;
                DateTime returnDate;
                bool oneWay = oneWay_rBtn.Checked;
                bool returnBooking = return_rBtn.Checked;

                oneway_groupBox.Text = originCity + "-->" + destCity;
                return_groupBox.Text = destCity + "-->" + originCity;
                
                if (originAbv != destAbv)
                {
                    //Check if flight departure is within 6 months of current time
                    if (deptDate <= currSysTime.AddDays(60))
                    {
                        oneway_groupBox.Show();
                        DataTable onewayOptionsTable = FormDatabaseHelper.getAvailableFlights(originAbv, destAbv, deptDate);
                        populateDataGridView(oneway_datagridview, onewayOptionsTable);



                        if (returnBooking)
                        {
                            returnDate = returnDate_dtp.Value;
                            return_groupBox.Show();
                            DataTable returnOptionsTable = FormDatabaseHelper.getAvailableFlights(destAbv, originAbv, returnDate);
                            populateDataGridView(return_datagridview, returnOptionsTable);

                        }
                        else
                        {
                            return_groupBox.Hide();
                            
                        }
                        //find flight 
                        


                        /*oneway_datagridview.DataSource = FormDatabaseHelper.getAvailableFlights(originAbv, destAbv, deptDate);
                        oneway_datagridview.AutoGenerateColumns = false;
                        oneway_datagridview.Columns[0].Name = "originAbv"; // name
                        oneway_datagridview.Columns[0].HeaderText = "origin header"; // header text
                        oneway_datagridview.Columns[0].DataPropertyName = "originAbv"; // field name
                        
                        oneway_datagridview.Columns[1].Name = "leg1dest"; // name
                        oneway_datagridview.Columns[1].HeaderText = "Leg 1 Dest"; // header text
                        oneway_datagridview.Columns[1].DataPropertyName = "leg1dest"; // field name

                        oneway_datagridview.Columns[2].Name = "leg2dest"; // name
                        oneway_datagridview.Columns[2].HeaderText = "Leg 2 Dest"; // header text
                        oneway_datagridview.Columns[2].DataPropertyName = "leg2dest"; // field name

                        oneway_datagridview.Columns[3].Name = "leg1deptTime"; // name
                        oneway_datagridview.Columns[3].HeaderText = "Leg 1 Dept"; // header text
                        oneway_datagridview.Columns[3].DataPropertyName = "leg1deptTime"; // field name

                        oneway_datagridview.Columns[4].Name = "leg1ArrivalTime"; // name
                        oneway_datagridview.Columns[4].HeaderText = "Leg 1 Arrival"; // header text
                        oneway_datagridview.Columns[4].DataPropertyName = "leg1ArrivalTime"; // field name

                        oneway_datagridview.Columns[5].Name = "leg2deptTime"; // name
                        oneway_datagridview.Columns[5].HeaderText = "Leg 2 Departure"; // header text
                        oneway_datagridview.Columns[5].DataPropertyName = "leg2deptTime"; // field name

                        oneway_datagridview.Columns[6].Name = "leg2ArrivalTime"; // name
                        oneway_datagridview.Columns[6].HeaderText = "Leg 2 Arrival"; // header text
                        oneway_datagridview.Columns[6].DataPropertyName = "leg2ArrivalTime"; // field name

                        oneway_datagridview.Columns[7].Visible = false;
                        oneway_datagridview.Columns[8].Visible = false;
                        oneway_datagridview.Columns[9].Visible = false;
                        oneway_datagridview.Columns[10].Visible = false;*/


                    }
                    else
                    {
                        Console.WriteLine("Depature date should be within 6 months");
                    }
                }
                else
                {
                    Console.WriteLine("origin and dest cannot be same");
                }


            }
            
            
        }

        public static void populateDataGridView(DataGridView gridview,DataTable table)
        {
            gridview.DataSource = table;
            gridview.AutoGenerateColumns = false;
            gridview.Columns[0].Name = "originAbv"; // name
            gridview.Columns[0].HeaderText = "origin header"; // header text
            gridview.Columns[0].DataPropertyName = "originAbv"; // field name

            gridview.Columns[1].Name = "leg1dest"; // name
            gridview.Columns[1].HeaderText = "Leg 1 Dest"; // header text
            gridview.Columns[1].DataPropertyName = "leg1dest"; // field name

            gridview.Columns[2].Name = "leg2dest"; // name
            gridview.Columns[2].HeaderText = "Leg 2 Dest"; // header text
            gridview.Columns[2].DataPropertyName = "leg2dest"; // field name

            gridview.Columns[3].Name = "leg1deptTime"; // name
            gridview.Columns[3].HeaderText = "Leg 1 Dept"; // header text
            gridview.Columns[3].DataPropertyName = "leg1deptTime"; // field name

            gridview.Columns[4].Name = "leg1ArrivalTime"; // name
            gridview.Columns[4].HeaderText = "Leg 1 Arrival"; // header text
            gridview.Columns[4].DataPropertyName = "leg1ArrivalTime"; // field name

            gridview.Columns[5].Name = "leg2deptTime"; // name
            gridview.Columns[5].HeaderText = "Leg 2 Departure"; // header text
            gridview.Columns[5].DataPropertyName = "leg2deptTime"; // field name

            gridview.Columns[6].Name = "leg2ArrivalTime"; // name
            gridview.Columns[6].HeaderText = "Leg 2 Arrival"; // header text
            gridview.Columns[6].DataPropertyName = "leg2ArrivalTime"; // field name

            gridview.Columns[7].Visible = false;
            gridview.Columns[8].Visible = false;
            gridview.Columns[9].Visible = false;
            gridview.Columns[10].Visible = false;
        }

    }
}
