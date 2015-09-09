using System.Collections.Generic;
using Domain.Entities;

namespace Domain
{
    public class Bracket
    {
        // een toernooi kan meerdere brackets hebben (meerdere poules)
        public int BracketId { get; set; }
        public string BracketNaam { get; set; }
        public int AantalRonden { get; set; }
        public int AantalDeelnemers { get; set; }
        public GameType Type { get; set; }       

        //FK's
        public int TournamentId { get; set; }
        public ICollection<LanUser> Deelnemers{ get; set; }
        public ICollection<BracketGame>  BracketGames { get; set; }
    }
}
