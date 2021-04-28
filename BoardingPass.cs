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
    public partial class BoardingPass : Form
    {
        public BoardingPass(User user,int ufh_id)
        {
            UserFlightHistory ticket = FormDatabaseHelper.GetUserFlightHistory(ufh_id);
            InitializeComponent();

            name_value_label.Text = user.lastName + " , " + user.firstName;
            account_value_label.Text = user.id.ToString();
            leg1_groupbox.Show();
            leg2_groupbox.Hide();
            layover_label.Hide();
            String fullflight="";

            String leg1ID = "";
            String leg1_flight = "";
            String leg1departure = "";
            String leg1Arrival = "";

            String layover = "";

            String leg2ID = "";
            String leg2_flight = "";
            String leg2departure = "";
            String leg2Arrival = "";


            leg1ID = ticket.leg1bookingId.ToString();
            leg2ID = ticket.leg2bookingId.ToString();
            leg1departure = ticket.departureDate.ToString();

            if (ticket.leg2bookingId == 0)
            {
                fullflight = ticket.originAbv + " ----> " + ticket.finaldestAbv;
                leg1Arrival = ticket.arrivalDate.ToString();
                leg1_flight = ticket.originAbv + " ----> " + ticket.finaldestAbv;

            }
            else
            {
                fullflight = ticket.originAbv + " ----> " + ticket.connectionAbv + " ---- >" + ticket.finaldestAbv;
                leg1_flight = ticket.originAbv + " ----> " + ticket.connectionAbv;
                leg1Arrival = ticket.leg1ArrivalDate.ToString();
                leg2departure = ticket.leg2deptDate.ToString();
                leg2Arrival = ticket.arrivalDate.ToString();
                leg2_flight = ticket.connectionAbv + " ---- >" + ticket.finaldestAbv;

                TimeSpan diff = ticket.leg2deptDate - ticket.leg1ArrivalDate;

                layover = diff.Hours.ToString() + "Hrs " +diff.Minutes+" min " +"Layover ";

                layover_label.Show();
                leg2_groupbox.Show();
            }

            fullflight_value_label.Text = fullflight;

            leg1_flightid_label.Text = leg1ID;
            leg1_dept_value_label.Text = leg1departure;
            leg1_arrival_value_label.Text = leg1Arrival;
            leg1_flight_label.Text = leg1_flight;

            layover_label.Text = layover;

            leg2_flightid_label.Text = leg2ID;
            leg2_dept_value_label.Text = leg2departure;
            leg2_arrival_value_label.Text = leg2Arrival;
            leg2_flight_label.Text = leg2_flight;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
