using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using BCrypt.Net;
using System.Configuration;


namespace Wvote
{
    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Register(object sender, EventArgs e)
        {
            string connectionString = "Data Source=HP\\SQLEXPRESS;" +
                "Initial Catalog=Voiting; " +
                "Integrated Security=True; " +
                "TrustServerCertificate=True";
            

            if (EmailText.Text.Contains("@"))
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string sqlQuery = "INSERT INTO Voter (FullName, Email, Password) VALUES (@FullName, @Email, @Password)";

                    using (SqlCommand sc = new SqlCommand(sqlQuery, con))
                    {
                        sc.Parameters.AddWithValue("@FullName", FullNameText.Text);
                        sc.Parameters.AddWithValue("@Email", EmailText.Text);

                        string hashedPassword = HashPassword(passwordT.Text);
                        sc.Parameters.AddWithValue("@Password", hashedPassword);

                        con.Open();
                        sc.ExecuteNonQuery();
                        con.Close();
                    }
                }

                FullNameText.Text = null;
                EmailText.Text = null;
                passwordT.Text = null;  
            }
            else
            {
                MessageBox.Show("Please enter correct email address");
            }
        }

        private void LogInLinkForm(object sender, LinkLabelLinkClickedEventArgs e) 
        {
            this.Hide();
            var editForm = new LogIn();
            var response = editForm.ShowDialog();

        }
         public string HashPassword(string password)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            return hashedPassword;
        }
    }
}
