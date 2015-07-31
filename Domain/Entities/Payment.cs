using System;

namespace Domain.Entities
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public DateTime Date { get; set; }
        public enum sort { cash, paypal, overschrijving}
    }
}
