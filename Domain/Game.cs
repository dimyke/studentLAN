using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Game
    {
        public int GameID { get; set; }
        public string GameNaam { get; set; }
        public int aantalSpelers { get; set; }

        public int GameTypeID { get; set; }
    }
}
