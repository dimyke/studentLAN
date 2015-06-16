using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Bracket
    {
        public int BracketID { get; set; }

        //FK's
        public int TournamentID { get; set; }        
    }
}
