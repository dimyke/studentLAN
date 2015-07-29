using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Betaling
    {
        public int BetalingID { get; set; }
        public DateTime Datum { get; set; }
        public enum soort { cash, paypal, overschrijving}
    }
}
