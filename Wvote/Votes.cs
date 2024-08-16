using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic.Logging;

namespace Wvote
{
    public partial class Votes : Form
    {
        public VoterInfo voter;
        public Pokemon pokemon;

        //connecting database
        private static string connectionString =
            "Data Source=HP\\SQLEXPRESS;" +
            "Initial Catalog=Voiting; " +
            "Integrated Security=True; " +
            "TrustServerCertificate=True";

        public Votes(VoterInfo voter)
        {
            this.voter = voter;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            int pokemonId = GetId(voter.FullName, voter.Email);
            string pokemonName = GetPokName(pokemonId);

            switch (pokemonName)
            {
                case "Pikachu":
                    pikachu.Checked = true;
                    Enabled();
                    break;
                case "Squirtle":
                    Squirtle.Checked = true;
                    Enabled();
                    break;
                case "Jolteon":
                    Jolteon.Checked = true;
                    Enabled();
                    break;
                case "0":
                    MessageBox.Show("Please try again");
                    break;
            }
        }

        private void pikachu_CheckedChanged(object sender, EventArgs e)
        {
            AddRightPokemon("Pikachu");
            Enabled();

        }

        private void Squirtle_CheckedChanged(object sender, EventArgs e)
        {
            
            AddRightPokemon("Squirtle");
            Enabled();
            
        }

        private void Jolteon_CheckedChanged(object sender, EventArgs e)
        {
            
            AddRightPokemon("Jolteon");
            Enabled();

        }

        //method to add each pokemon
        public void AddRightPokemon(string pokemonName)
        {
         string sqlQuery = "INSERT INTO Pokemon (PokemonName) OUTPUT INSERTED.PokemonId VALUES (@PokemonName)";

            using(SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand sc = new SqlCommand(sqlQuery, con))
                {
                    if (!HasVoted())
                    {
                        sc.Parameters.AddWithValue("@PokemonName", pokemonName);

                        con.Open();
                        int pokemonId = Convert.ToInt32(sc.ExecuteScalar());
                        con.Close();

                        AddVote(voter.FullName, voter.Email, pokemonId);

                    }
                    else
                    {
                        MessageBox.Show("You have voted already for " + pokemonName);
                    }
                }
                    
            }
        
            
        }

        private bool HasVoted()
        {
            int pokemonId = GetId(voter.FullName, voter.Email);
            return pokemonId != 0; // If pokemonId is not 0, it means the user has already voted
        }

        public void AddVote(string voterFullName, string voterEmail, int pokemonId)
        {
            string getVoterIdQuery = "SELECT VoterId FROM Voter WHERE FullName = @FullName AND Email = @Email";
            int voterId;

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                using (SqlCommand sqlcm = new SqlCommand(getVoterIdQuery, con))
                {
                    sqlcm.Parameters.AddWithValue("@FullName", voterFullName);
                    sqlcm.Parameters.AddWithValue("@Email", voterEmail);

                    con.Open();
                    object result = sqlcm.ExecuteScalar();
                    con.Close();

                    if (result != null)
                    {
                        voterId = Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new Exception("Voter not found.");
                    }
                }

                string insertQuery = "INSERT INTO dbo.Result (VoterId, PokemonId) VALUES (@VoterId, @PokemonId)";

                using (SqlCommand command = new SqlCommand(insertQuery, con))
                {
                    command.Parameters.AddWithValue("@VoterId", voterId);
                    command.Parameters.AddWithValue("@PokemonId", pokemonId);

                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public void Enabled()
        {
            pikachu.Enabled = false;
            Squirtle.Enabled = false;
            Jolteon.Enabled = false;
        }
        public int GetId(string voterFullName, string voterEmail)
        {
            //check if the user exists
            string getVoterIdQuery = "SELECT VoterId FROM Voter WHERE FullName = @FullName AND Email = @Email";
            int voterId;

            using (SqlConnection con = new SqlConnection(connectionString))
            {


                using (SqlCommand sqlcm = new SqlCommand(getVoterIdQuery, con))
                {
                    sqlcm.Parameters.AddWithValue("@FullName", voterFullName);
                    sqlcm.Parameters.AddWithValue("@Email", voterEmail);

                    con.Open();
                    object result = sqlcm.ExecuteScalar();
                    con.Close();
                    //if the user exists - check if he has voted
                    if (result != null)
                    {
                        voterId = Convert.ToInt32(result);

                        string getPokemonIdQuery = "SELECT PokemonId FROM Result WHERE VoterId = @VoterId";

                        using (SqlCommand cmd = new SqlCommand(getPokemonIdQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@VoterId", voterId);

                            con.Open();
                            object resultPokId = cmd.ExecuteScalar();
                            int pokemonId = Convert.ToInt32(resultPokId);
                            con.Close();

                            return pokemonId;
                        }
                    }
                    else
                    {
                        //if doesn't exists - return 0 (no 0 id in the table)
                        return 0;
                    }
                }
            }
        }
        public string GetPokName(int pokemonId)
        {
            string getPokemonIdQuery = "SELECT PokemonName FROM Pokemon WHERE PokemonId = @PokemonId";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(getPokemonIdQuery, con))
                {
                    cmd.Parameters.AddWithValue("@PokemonId", pokemonId);

                    con.Open();
                    object resultPokId = cmd.ExecuteScalar();
                    string pokemonName = Convert.ToString(resultPokId);
                    con.Close();

                    return pokemonName;
                }
            }
        }
    }
}