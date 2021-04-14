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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            //go to user landing page
            this.Visible = false;
            landing_page s = new landing_page();
            s.Visible = true;

        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            
            //Go to sign up page
            this.Visible = false;     
            Signup s = new Signup();  
            s.Visible = true;
        }

       
    }
}
