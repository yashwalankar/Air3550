using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

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
            //go to individual user landing page based on returned user type
            // type 1 = normal user
            // type 2 = load engineer
            // type 3 = flight manager
            // type 4 = marketing manager
            // type 5 = accountant

            string userID = userID_textbox.Text;

            string userPassword = pass_textbox.Text;
            string encryptedPassword = TextToSHA512(userPassword);

            bool userExists = PasswordCheck(userID, encryptedPassword);

            if (userExists == true)
            {
                User userData = AccountInformation(userID, encryptedPassword);
            }

            //this.Visible = false;
            //landing_page s = new landing_page();
            //s.Visible = true;

        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            
            //Go to sign up page
            this.Visible = false;     
            Signup s = new Signup(this);  
            s.Visible = true;
        }


        //-----------------------------Page methods----------------------------
        
        // Text to SHA512 for password encryption
        public string TextToSHA512(string password)
        {
            string encryptedPassword = null;
            SHA512 hasher = SHA512.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hash = hasher.ComputeHash(bytes);

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            encryptedPassword = result.ToString();
            return encryptedPassword;
        }
        
        // Search DB for account existing with correct password,
        // returns true if exists and false if info incorrect or nonexisting
        public bool PasswordCheck(string username, string encryptedPassword)
        {
            bool passwordGood = false;
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;

            using (SqlConnection sqlConnection = new SqlConnection(dbString)){
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM UserAccountData " +
                                                              "WHERE UserID LIKE @username " +
                                                              "AND Password LIKE @password", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@username", username);
                    sqlCommand.Parameters.AddWithValue("@password", encryptedPassword);
                    int userCount = (int)sqlCommand.ExecuteScalar();

                    if (userCount > 0)
                    {
                        passwordGood = true;
                    }
                }

                return passwordGood;
            }
        }

        // Package User Data into a Table for use in selecting landing page
        // and for filling page info
        public User AccountInformation(string username, string encryptedPassword)
        {
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;

            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();

                User info = new User();

                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM UserAccountData " +
                                                              "WHERE UserID LIKE @username " +
                                                              "AND Password LIKE @password", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@username", username);
                    sqlCommand.Parameters.AddWithValue("@password", encryptedPassword);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = sqlCommand;

                    DataTable userDataSet = new DataTable();
                    adapter.Fill(userDataSet);

                    info.id = userDataSet.Rows[0].Field<int>("UserID");
                    info.type = userDataSet.Rows[0].Field<int>("Type");
                    info.age = userDataSet.Rows[0].Field<int>("Age");
                    info.rewardBalance = userDataSet.Rows[0].Field<int>("RewardBalance");
                    info.userHistoryID = userDataSet.Rows[0].Field<int>("UserHistID");
                    info.passwordHash = userDataSet.Rows[0].Field<string>("FirstName");
                    info.firstName = userDataSet.Rows[0].Field<string>("FirstName");
                    info.lastName = userDataSet.Rows[0].Field<string>("LastName");
                    info.address = userDataSet.Rows[0].Field<string>("Address");
                    info.cardNumber = userDataSet.Rows[0].Field<string>("CardNum");
                }

                return info;
            }
        }
    }

}
