namespace Domain.Entities
{
    public class Order:IOrder
    {

        public int OrderId { get; set; }
        public string GebruikerId { get; set; }
        public bool Deleted { get; set; }

        public double TotaalBedrag { get; set; }

        // Foreign Key
        public int BestlingLijnId { get; set; }



    }
}
