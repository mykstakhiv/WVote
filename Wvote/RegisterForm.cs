using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using BCrypt.Net;
using System.Configuration;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;


namespace Wvote
{
    public partial class RegisterForm : Form
    {

        public SqlConnectionString conn = new SqlConnectionString();

        public RegisterForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Register(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FullNameText.Text) &&
                string.IsNullOrEmpty(EmailText.Text) &&
                string.IsNullOrEmpty(passwordT.Text))
            {

                MessageBox.Show("Please fill all boxes");
                return;
            }

            bool check = CheckVoter(EmailText.Text);

            if (!check == false)
            {
                MessageBox.Show("User already exists");
                return;
            }
            if (!EmailText.Text.Contains("@"))
            {
                MessageBox.Show("Please enter correct email address");
                return;
            }

            Regex symbols = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^a-zA-Z\\d]).+$");
            if (!symbols.IsMatch(passwordT.Text))
            {
                MessageBox.Show("Make sure that your password is secure");
                return;
            }

            string connectionString = conn.ConnectionString;
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

        public bool CheckVoter(string email)
        {
            string connectionString = conn.ConnectionString;

            string query = "SELECT COUNT(*) FROM Voter WHERE Email = @Email";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@Email", email);

                        int count = (int)command.ExecuteScalar();

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

                return true;
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