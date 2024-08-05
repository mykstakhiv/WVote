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
        public VoterInfo(string name, string email)
        {
            FullName = name;
            Email = email;
        }
        public string FullName { get; init; } 
        public string Email { get; init; } 

        
    }

    public class Pokemon(string pokName) 
    {
        public string PokemonName { get; init; } = pokName;
    }
}
