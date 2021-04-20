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
    public partial class FlightManLandingPage : Form
    {
        public FlightManLandingPage()
        {
            InitializeComponent();
        }

        private void printManifest_btn_Click(object sender, EventArgs e)
        {
            flightManifest manifest = new flightManifest();
            manifest.Visible = true;
        }

        



    }
}
