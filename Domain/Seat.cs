﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Seat
    {
        public int SeatID { get; set; }
        //regular or VIP
        public TicketSort SeatSort { get; set; }
    }
}