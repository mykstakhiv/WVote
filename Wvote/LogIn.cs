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
        private static VoterInfocs inf = new VoterInfocs();
        private static Votes vt = new Votes();

        private static LogIn instance;
        private static RegisterForm reg;

        public static LogIn Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LogIn();
                }
                return instance;
            }
        }


        public LogIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RegisterLinkOpenForm(object sender, LinkLabelLinkClickedEventArgs e) 
        {
            this.Hide();
            RegisterForm.Instance.Show();
        }
        
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
