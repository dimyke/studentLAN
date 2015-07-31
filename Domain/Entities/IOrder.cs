namespace Domain.Entities
{
    public interface IOrder
    {
        int OrderID { get; set; }

        // Foreign Key
        string GebruikerID { get; set; }
    }
}
