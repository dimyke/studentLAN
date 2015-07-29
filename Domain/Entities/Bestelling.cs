using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Bestelling:IOrder
    {
        public double TotaalBedrag { get; set; }

        // Foreign Key
        public int BestlingLijnID { get; set; }
    }
}
