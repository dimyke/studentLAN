namespace Domain.Entities
{
    public interface IOrder
    {
        int OrderId { get; set; }
        bool Deleted { get; set; }
        // Foreign Key
        string GebruikerId { get; set; }
    }
}
