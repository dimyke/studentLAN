﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Seat
    {
        public int SeatID { get; set; }
        //regular or VIP
        public int SeatRow { get; set; }
        public int SeatColumn { get; set; }
        public SeatSort SeatSort { get; set; }
        public enum State
        {
            Reserved,Booked,Free
        }
    }
}
