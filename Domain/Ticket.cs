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
        public TicketSort Ticketsort { get; set; }
        public int TicketPrice { get; set; }

        public enum TicketType
        {
            Saturday, Sunday,Weekend
        }
    }
}
