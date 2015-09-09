namespace Domain.Entities
{
    public class TicketType
    {
        public int TicketTypeId { get; set; }
        public enum Day {Saturday,Sunday,Weekend }
        public int Price { get; set; }
        public SeatSort SeatSort { get; set; }

    }
}
