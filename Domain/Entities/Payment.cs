using System;

namespace Domain.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public DateTime Date { get; set; }
        public enum Sort { Cash, Paypal, Overschrijving}
    }
}
