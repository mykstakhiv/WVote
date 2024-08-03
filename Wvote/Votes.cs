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
using Microsoft.VisualBasic.Logging;

namespace Wvote
{
    public partial class Votes : Form
    {
        public VoterInfo voter;


        private static string connectionString = 
            "Data Source=HP\\SQLEXPRESS;" +
            "Initial Catalog=Voiting; " +
            "Integrated Security=True; " +
            "TrustServerCertificate=True";
        private static string sqlQuery = "INSERT INTO Pokemon (PokemonName) VALUES (@PokemonName)";

        public static SqlConnection con = new SqlConnection(connectionString);
        public SqlCommand sc = new SqlCommand(sqlQuery, con);

        public Votes(VoterInfo voter)
        {
            this.voter = voter;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;    
        }

        private void pikachu_CheckedChanged(object sender, EventArgs e)
        {

            if (pikachu.Checked == true && Jolteon.Checked != true && Squirtle.Checked != true)
            {
                sc.Parameters.AddWithValue("@PokemonName", "Pikachu");

                con.Open();
                sc.ExecuteNonQuery();

                string query = "SELECT * FROM Result";
                
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    string fullName = reader.GetString(1);
                    string email = reader.GetString(2);

                    if (fullName == voter.FullName)
                    {
                        if (email == voter.Email)
                        {
                            int id = reader.GetInt32(0);
                            string sqlQuery = "INSERT INTO Result (VoterId, PokemonId) " +
                                              "VALUES (@VoterId, @PokemonID)";


                            SqlConnection con = new SqlConnection(connectionString);
                            SqlCommand sc = new SqlCommand(sqlQuery, con);
                            sc.Parameters.AddWithValue("@VoterId", id);
                            sc.Parameters.AddWithValue("@PokemonId", id);
                            break;
                        }

                    }
                }

                con.Close();
            }
            else
            {
                MessageBox.Show("You have voted already");
            }
            
        }

        private void Squirtle_CheckedChanged(object sender, EventArgs e)
        {
            if (pikachu.Checked != true && Jolteon.Checked != true && Squirtle.Checked == true)
            {
                sc.Parameters.AddWithValue("@PokemonName", "Squirtle");

                con.Open();
                sc.ExecuteNonQuery();
                con.Close();

                //string fullName = reader.GetString(1);
                //string email = reader.GetString(2);
            }
            else
            {
                MessageBox.Show("You have voted already");
            }
           
        }

        private void Jolteon_CheckedChanged(object sender, EventArgs e)
        {
            if (pikachu.Checked != true && Jolteon.Checked == true && Squirtle.Checked != true)
            {
                sc.Parameters.AddWithValue("@PokemonName", "Jolteon");

                con.Open();
                sc.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("You have voted already");
            }
        }
    }
}
