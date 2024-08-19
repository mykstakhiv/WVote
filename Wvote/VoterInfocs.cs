using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Wvote
{
    //Class to communicate between forms
    public class VoterInfo
    {
        public string FullName { get; init; }
        public string Email { get; init; }

        public VoterInfo(string name, string email)
        {
            FullName = name;
            Email = email;
        }
    }

    public class Pokemon(string pokName) 
    {
        public string PokemonName { get; init; } = pokName;
    }

    public class SqlConnectionString 
    {
        public string ConnectionString { get; } 

        public SqlConnectionString()
        {
            ConnectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=Voiting; Integrated Security=True; TrustServerCertificate=True";
        }
        
    }
}
