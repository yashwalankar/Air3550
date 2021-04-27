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
    public partial class Checkout : Form
    {
       
        public Checkout(bool tripTypeisReturn,User user, UserFlightHistory fh1, UserFlightHistory fh2)
        {
            
            InitializeComponent();
            userid_label.Text = user.id.ToString();
            userreward_balance_label.Text = user.rewardBalance.ToString();

            String fh1_str = "";
            if(fh1.leg2bookingId ==0)
            {
                fh1_str = fh1.originAbv + "--->" + fh1.finaldestAbv + " | " + fh1.departureDate.ToString() + " | " + fh1.arrivalDate.ToString();
            }
            else
            {
                fh1_str = fh1.originAbv + "-->"+fh1.connectionAbv+"-->" + fh1.finaldestAbv + " | " + fh1.departureDate.ToString() + " | " + fh1.arrivalDate.ToString();
            }
            flight1_value_label.Text = fh1_str;

            if (tripTypeisReturn)
            {
                flight2_value_label.Show();
                flight2_label.Show();
                String fh2_str = "";
                if (fh2.leg2bookingId == 0)
                {
                    fh2_str = fh2.originAbv + "--->" + fh2.finaldestAbv + " | " + fh2.departureDate.ToString() + " | " + fh2.arrivalDate.ToString();
                }
                else
                {
                    fh2_str = fh2.originAbv + "-->" + fh2.connectionAbv + "-->" + fh2.finaldestAbv + " | " + fh2.departureDate.ToString() + " | " + fh2.arrivalDate.ToString();
                }
                flight2_value_label.Text = fh2_str;
            }
            else
            {
                flight2_value_label.Hide();
                flight2_label.Hide();
            }
            


        }

        private void book_btn_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
