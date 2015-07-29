using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Bestelling:IOrder
    {
        public int BestellingID { get; set; }
        public string GebruikerID { get; set; }
        public double Bedrag { get; set; }
    }
}
