using System.Collections.Generic;

namespace Domain
{
    public class Team
    {
        public int TeamID { get; set; }
        public string TeamNaam { get; set; }
        public ICollection<LanUser> Leden { get; set; }
    }
}
