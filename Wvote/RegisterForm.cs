using Microsoft.Data.SqlClient;
namespace Wvote
{
    public partial class RegisterForm : Form
    {
        private static LogIn log = new LogIn();
        
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void ShowLogForm() 
        {
 
            if (!log.Visible)
            {
                log.Show();
            }
            else
            {
                log.BringToFront();
                log.Focus();
            }

        } 
        private void Register(object sender, EventArgs e)
        {
            string connectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=Voiting-Stah; Integrated Security=True; TrustServerCertificate=True";
            string sqlQuery = "INSERT INTO Voter (FullName, Email) VALUES (" + "'" + FullNameText.Text + "'" + "," + "'" + EmailText.Text + "'" + ")";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }

        private void LogInLinkForm(object sender, LinkLabelLinkClickedEventArgs e) => ShowLogForm();
        
    }
}
