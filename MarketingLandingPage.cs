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
    public partial class MarketingLandingPage : Form
    {
        public MarketingLandingPage()
        {
            InitializeComponent();
            FormDatabaseHelper.FillPlaneModelsBox(planesModels_comboBox);
        }

        
        

        private void planesModels_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormDatabaseHelper.updateCapacityBox(planesModels_comboBox.SelectedItem.ToString() , newCapacityValue_label);
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Dispose();
            Login s = new Login();
            s.Visible = true;
        }
    }
}
