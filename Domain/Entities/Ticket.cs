namespace Domain
{
    public class Ticket
    {
        public int TicketId { get; set; }
        // regular or vip
        public int TicketTypeId { get; set; }
        public int GebruikerId { get; set; }
        public int SeatPlaatsId { get; set; }
    }
}
