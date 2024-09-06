using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Collections;
using Microsoft.VisualBasic.Logging;

namespace Wvote
{
    public partial class LogIn : Form
    {
        //instance of VoterInfo class to be able to move 
        //details into Votes form
        public VoterInfo voter;

        public SqlConnectionString conn = new SqlConnectionString();

        public LogIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void RegisterLinkOpenForm(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var editForm = new RegisterForm();
            var response = editForm.ShowDialog();
        }

        //TC = O(log N), SC = O(1)
        private void LogInBttn(object sender, EventArgs e)
        {
            string connectionString = conn.ConnectionString;


            string query = "SELECT FullName, Email, Password FROM Voter WHERE FullName = @FullName AND Email = @Email";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@FullName", FullNameText.Text);
                    command.Parameters.AddWithValue("@Email", EmailText.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        bool isValidUser = false;

                        while (reader.Read())
                        {

                            string fullName = reader.GetString(0);
                            string email = reader.GetString(1);
                            string hashedPassword = reader.GetString(2);

                            if (fullName == FullNameText.Text && email == EmailText.Text)
                            {
                                if (VerifyPassword(passwordT.Text, hashedPassword) == true)
                                {
                                    isValidUser = true;

                                    this.Hide();
                                    //initialization of the object with Name and Email - LogIn
                                    voter = new VoterInfo(FullNameText.Text, EmailText.Text);
                                    var editForm = new Votes(voter);
                                    var response = editForm.ShowDialog();
                                    break;
                                }
                                else
                                {
                                    // Password mismatch
                                    MessageBox.Show("Incorrect password or email. Please try again.");
                                    return;
                                }
                            }
                        }
                        if (!isValidUser)
                        {
                            MessageBox.Show("User not found. Please check your name and email.");
                        }
                    }   
                }
            }                
        }
        public bool VerifyPassword(string password, string hashedPassword)
        {
            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, hashedPassword);
            return isPasswordValid;
        }

        private void showPassword(object sender, EventArgs e)
        {
            if (showPass.Checked == true)
            {
                passwordT.PasswordChar = '\0';
                return;
            }
            else if (showPass.Checked == false)
            {
                passwordT.PasswordChar = '#';
                return;
            }
            else
            {
                return;
            }
        }
    }
}
