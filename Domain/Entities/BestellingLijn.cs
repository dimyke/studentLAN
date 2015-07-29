using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class BestellingLijn
    {
        public int BestellingLijnID { get; set; }
        public int ConsumptieID { get; set; }
        public int Aantal { get; set; }
        public double Bedrag { get; set; }

    }
}
