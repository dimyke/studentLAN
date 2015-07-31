using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Team
    {
        public int TeamID { get; set; }
        public string TeamNaam { get; set; }
        public ICollection<LanUser> Leden { get; set; }
    }
}
