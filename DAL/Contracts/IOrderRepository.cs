using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace DAL.Contracts
{
    public interface IOrderRepository
    {
        Order CreateOrder(Order order);

        IEnumerable<Order> ReadOrders();

        void updateOrder(int orderNumber);
        void ToggleDeletedSatus();

    }
}
