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

        
    }
}
