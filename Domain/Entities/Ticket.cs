namespace Domain
{
    public class Ticket
    {
        public int TicketID { get; set; }
        // regular or vip
        public int TicketTypeID { get; set; }
        public int GebruikerID { get; set; }
        public int SeatPlaatsID { get; set; }
    }
}
