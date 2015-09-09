using System.Collections.Generic;

namespace Domain
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamNaam { get; set; }
        public ICollection<LanUser> Leden { get; set; }
    }
}
