namespace Domain.Entities
{
    public class OrderLine
    {
        public int BestellingLijnID { get; set; }
        public int ConsumptieID { get; set; }
        public int Aantal { get; set; }
        public double Bedrag { get; set; }
    }
}
