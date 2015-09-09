using System.Collections.Generic;

namespace Domain
{
    public class Tournament
    {
        public int TournamentId { get; set; }
        public string TournamentName { get; set; }
        public int MaxPlayers { get; set; }

        // Saturday or Sunday
        public enum Day
        {
            Saturday, Sunday
        }

        public enum Status
        {
            Open, Full, NowPlaying, Ended
        }

        //Foreign Key
        public int GameId { get; set; }
        public ICollection<Bracket> Brackets { get; set; }
        public ICollection<LanUser> Leden { get; set; }
    }
}
