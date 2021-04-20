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
    public partial class Signup : Form
    {
        Login ParentPage;
        int uniqueUserID;

        public Signup(Login LoginPage)
        {
            InitializeComponent();

            ParentPage = LoginPage;
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            uniqueUserID = uniqueID();
            userid_textbox.Text = uniqueUserID.ToString();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            //Add data to database/csv
            User newUser = new User();

            bool passwordsMatch = false;
            bool requiredFieldsFilled = false;
            int requiredFieldCount = 0;

            if (pass_textbox.Text == confirmpass_textbox.Text)
            {
                passwordsMatch = true;
            }

            if (firstname_textbox.Text != null) requiredFieldCount++;
            if (lastname_textbox.Text != null) requiredFieldCount++;
            if (address_textbox.Text != null) requiredFieldCount++;
            if (pass_textbox.Text != null) requiredFieldCount++;
            if (confirmpass_textbox.Text != null) requiredFieldCount++;
            if (age_textbox.Text != null) requiredFieldCount++;
            if (email_textbox.Text != null) requiredFieldCount++;
            if (phone_textbox.Text != null) requiredFieldCount++;
            if (requiredFieldCount == 8)
            {
                requiredFieldsFilled = true;
            }

            if (passwordsMatch && requiredFieldsFilled)
            {
                newUser = setupUser();
                addUserToDB(newUser);
            }

            //go back to login page 
            this.Visible = false;
            this.Dispose();
            ParentPage.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Dispose();
            ParentPage.Visible = true;
        }

        private int uniqueID()
        {
            int newUserID = 0;
            bool uniqueIDFound = false;
            int count = 0;

            string dbString = Properties.Settings.Default.Air3550DBConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM UserAccountData " +
                                                             "WHERE UserID LIKE @userID", sqlConnection))
                {
                    Random rnd = new Random();
                    while (!uniqueIDFound)
                    {
                        newUserID = rnd.Next(100000, 999999);
                        //newUserID = 123456; //Debug with test userID to check if existing ID doesnt work.

                        sqlCommand.Parameters.AddWithValue("@userID", newUserID);
                        count = (int)sqlCommand.ExecuteScalar();
                        if (count == 0)
                        {
                            uniqueIDFound = true;
                        }
                        sqlCommand.Parameters.RemoveAt(0);
                    }
                }

                return newUserID;
            }
        }

        private User setupUser()
        {
            User newUser = new User();

            newUser.id = uniqueUserID;
            newUser.passwordHash = TextToSHA512(pass_textbox.Text);
            newUser.type = 1;
            newUser.firstName = firstname_textbox.Text;
            newUser.lastName = lastname_textbox.Text;
            newUser.age = int.Parse(age_textbox.Text);
            newUser.email = email_textbox.Text;
            newUser.phone = phone_textbox.Text;
            newUser.address = address_textbox.Text;
            newUser.cardNumber = "";
            newUser.rewardBalance = 0;
            newUser.userHistoryID = uniqueUserID;

            return newUser;
        }

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

        private void addUserToDB(User user)
        {
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();

                string sqlString = $"INSERT INTO UserAccountData " +
                    $"(UserID,Password,Type,FirstName,LastName,Age,Email,Phone," +
                    $"Address,CardNum,RewardBalance,UserHistID) " +
                    $"VALUES ('{user.id}','{user.passwordHash}','{user.type}','{user.firstName}'," +
                    $"'{user.lastName}','{user.age}','{user.email}','{user.phone}','{user.address}'," +
                    $"'{user.cardNumber}','{user.rewardBalance}','{user.userHistoryID}')";

                SqlCommand command = new SqlCommand(sqlString, sqlConnection);
                command.ExecuteNonQuery();

                Console.WriteLine(sqlString);
            }
        }
    }
}
                 