using Microsoft.Data.SqlClient;
using System.Windows.Forms;
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
                string sqlQuery = "INSERT INTO Voter (FullName, Email) VALUES (" + "'" + FullNameText.Text + "'" + "," + "'" + EmailText.Text + "'" + ")";
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                SqlCommand sc = new SqlCommand(sqlQuery, con);
                sc.ExecuteNonQuery();
                con.Close();

                FullNameText.Text = null;
                EmailText.Text = null;
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
        
    }
}
