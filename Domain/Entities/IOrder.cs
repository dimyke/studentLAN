using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    interface IOrder
    {
        public int OrderID { get; set; }

        // Foreign Key
        public string GebruikerID { get; set; }
    }
}
