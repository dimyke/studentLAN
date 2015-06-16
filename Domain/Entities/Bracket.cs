using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Bracket
    {
        // een toernooi kan meerdere brackets hebben (meerdere poules)
        public int BracketID { get; set; }
        public string BracketNaam { get; set; }
        public int AantalRonden { get; set; }
        public int AantalDeelnemers { get; set; }
        public GameType Type { get; set; }       

        //FK's
        public int TournamentID { get; set; }
        
        

    }
}
