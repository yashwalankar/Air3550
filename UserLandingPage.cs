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
            }
            else
            {
                returnDate_label.Hide();
                returnDate_dtp.Hide();
            }

        }

        private void showFlights_btn_Click(object sender, EventArgs e)
        {
            bool oneWayBooking = oneWay_rBtn.Checked;
            bool returnBooking = return_rBtn.Checked;


            DateTime currentTime = currSysTime_DTP.Value;

            if(origin_comboBox.SelectedItem != null && destination_comboBox.SelectedItem !=null )
            {
                String origin = FormDatabaseHelper.getAirportAbvFromCity(origin_comboBox.SelectedItem.ToString());

                String dest = FormDatabaseHelper.getAirportAbvFromCity(destination_comboBox.SelectedItem.ToString());

                DateTime deptTime = deptDate_dtp.Value;
                if (origin != dest)
                {
                    if (deptTime > currentTime.AddDays(60))
                    {
                        Console.WriteLine("Bookingings cannot be more than 60days out");
                    }
                    else
                    {
                        Console.WriteLine("One way" + oneWayBooking);
                        Console.WriteLine("Return booking" + returnBooking);

                        Console.WriteLine("Origin" + origin);
                        Console.WriteLine("destination" + dest);
                    }
                }
                else
                {
                    Console.WriteLine("orign and destination cannot be same");
                }

                

            }
            else
            {
                Console.WriteLine("Select origin and destination pls");
            }
            
            

        }
    }
}
