using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Tournament
    {
        public int TournamentID { get; set; }
        public string TournamentName { get; set; }
        public int MaxPlayers { get; set; }


        //Foreign Key
        public int GameID { get; set; }
    }
}
