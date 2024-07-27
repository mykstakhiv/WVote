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

namespace Wvote
{
    public partial class Votes : Form
    {
        public Votes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pikachu_CheckedChanged(object sender, EventArgs e)
        {
            if (pikachu.Checked == true)
            {
                string connectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=Voiting_System; Integrated Security=True; TrustServerCertificate=True";

                
                string sqlQuery = "INSERT INTO Pokemon (PokemonName) VALUES (@PokemonName)";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand sc = new SqlCommand(sqlQuery, con);

                sc.Parameters.AddWithValue("@PokemonName", "Pikachu");

                con.Open();
                sc.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
