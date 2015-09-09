namespace Domain.Entities
{
    public class TicketType
    {
        public int TicketTypeID { get; set; }
        public enum Day {Saturday,Sunday,Weekend }
        public int Price { get; set; }
        public SeatSort SeatSort { get; set; }

    }
}
