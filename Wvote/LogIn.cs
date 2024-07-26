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

namespace Wvote
{
    public partial class LogIn : Form
    {
        private static RegisterForm reg = new RegisterForm();
        private static VoterInfocs inf = new VoterInfocs();
        private static Votes vt = new Votes();


        public LogIn()
        {
            InitializeComponent();
        }

        private void ShowRegForm()
        {
            if (!reg.Visible)
            {
                reg.Show();
            }
            else
            {
                reg.BringToFront();
                reg.Focus();
            }
        }
        private void RegisterLinkOpenForm(object sender, LinkLabelLinkClickedEventArgs e) => ShowRegForm();

        private void LogInBttn(object sender, EventArgs e)
        {
            string connectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=Voiting-Stah; Integrated Security=True; TrustServerCertificate=True";
            

            string query = "SELECT * FROM Voter";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                
                string fullName = reader.GetString(1);
                string email = reader.GetString(2);

                if (fullName == FullNameText.Text || email == EmailText.Text)
                {
                    vt.Show();
                    break;
                }
            }

        }
    }
}
