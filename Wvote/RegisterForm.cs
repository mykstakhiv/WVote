using Microsoft.Data.SqlClient;
using System.Windows.Forms;
namespace Wvote
{
    public partial class RegisterForm : Form
    {
        private static RegisterForm instance;
        private static LogIn log;

        public static RegisterForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RegisterForm();
                }
                return instance;
            }
        }

        public RegisterForm()
        {
            InitializeComponent();
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

        private void LogInLinkForm(object sender, LinkLabelLinkClickedEventArgs e) 
        {
            this.Hide();
            LogIn.Instance.Show();

        }
        
    }
}
