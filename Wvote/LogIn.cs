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

        private void LogInBttn(object sender, EventArgs e)
        {
            string connectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=Voiting; Integrated Security=True; TrustServerCertificate=True";


            string query = "SELECT * FROM Voter";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                string fullName = reader.GetString(1);
                string email = reader.GetString(2);
                string hashedPassword = reader.GetString(3);

                if (fullName == FullNameText.Text)
                {
                    if (email == EmailText.Text)
                    {
                        if (VerifyPassword(passwordT.Text, hashedPassword))
                        {
                            this.Hide();
                            //initialization of the object with Name and Email - LogIn
                            voter = new VoterInfo(FullNameText.Text, EmailText.Text);
                            var editForm = new Votes(voter);
                            var response = editForm.ShowDialog();
                            break;
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
    }
}
