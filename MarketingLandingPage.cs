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
            FillPlaneModelsBox(planesModels_comboBox);
        }

        private void FillPlaneModelsBox(ComboBox box)
        {
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();


                using (SqlCommand sqlCommand = new SqlCommand("SELECT PlaneModel FROM PlaneModel ", sqlConnection))
                {


                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        box.Items.Add(sqlReader["PlaneModel"].ToString());
                    }

                    sqlReader.Close();
                }


            }

        }
        private void updateCapacityBox(String planeModelInput)
        {
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();


                using (SqlCommand sqlCommand = new SqlCommand("SELECT Capacity FROM PlaneModel WHERE PlaneModel LIKE @planeModelInput ", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@planeModelInput", planeModelInput);

                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                    

                    while (sqlReader.Read())
                    {
                        newCapacityValue_label.Text = sqlReader["Capacity"].ToString();
                    }

                    sqlReader.Close();
                }


            }
        }

        private void planesModels_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCapacityBox(planesModels_comboBox.SelectedItem.ToString());
        }
    }
}
