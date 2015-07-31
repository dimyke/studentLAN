namespace Domain.Entities
{
    public class Order:IOrder
    {

        public int OrderID { get; set; }
        public string GebruikerID { get; set; }

        public double TotaalBedrag { get; set; }

        // Foreign Key
        public int BestlingLijnID { get; set; }



    }
}
