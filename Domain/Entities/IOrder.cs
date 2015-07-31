using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public interface IOrder
    {
        int OrderID { get; set; }

        // Foreign Key
        string GebruikerID { get; set; }
    }
}
