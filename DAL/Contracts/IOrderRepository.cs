using System.Collections.Generic;
using Domain.Entities;

namespace DAL.Contracts
{
    public interface IOrderRepository
    {
        Order CreateOrder(Order order);

        IEnumerable<Order> ReadOrders();

        //TODO wat gebeurt bij een update? Toevoegen van een lijn?
        void UpdateOrder(int orderNumber);
        void AddOrderLine(OrderLine line);
        void ToggleDeletedSatus();

    }
}
