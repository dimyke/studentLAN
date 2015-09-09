namespace Domain.Entities
{
    public class OrderLine
    {
        public int BestellingLijnId { get; set; }
        public int ConsumptieId { get; set; }
        public int Aantal { get; set; }
        public double Bedrag { get; set; }
    }
}
