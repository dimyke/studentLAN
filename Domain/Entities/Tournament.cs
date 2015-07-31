using System.Collections.Generic;

namespace Domain
{
    public class Tournament
    {
        public int TournamentID { get; set; }
        public string TournamentName { get; set; }
        public int MaxPlayers { get; set; }

        // Saturday or Sunday
        public enum Day
        {
            Saturday, Sunday
        }

        //Foreign Key
        public int GameID { get; set; }
        public ICollection<LanUser> Leden { get; set; }
    }
}
