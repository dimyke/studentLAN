using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Ticket
    {
        public int TicketID { get; set; }
        // regular or vip
        public int TicketTypeID { get; set; }
        public int GebruikerID { get; set; }
        public int SeatPlaatsID { get; set; }
    }
}
