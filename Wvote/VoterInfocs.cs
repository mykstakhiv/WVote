using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wvote
{
    public class VoterInfocs
    {
        public List<int> Id { get; set; }
        public List<string> FullName { get; set; }
        public List<string> Email { get; set; } = new List<string>();
    } 
}
