using Microsoft.AspNet.Identity.EntityFramework;
using System;


namespace Domain
{
    public class LanUser : IdentityUser
    {
        public override string Id { get; set; }
        public override string UserName { get; set; }
        public override string Email { get; set; }

        public string Avatar { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string Postcode { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string Origin { get; set; }
        public string Steam { get; set; }
        public string Nickname { get; set; }
        public string BatlleNet { get; set; }
        public string Wargaming { get; set; }

        public bool NewsletterSubscription { get; set; }

        // foreign key
        public int WalletID { get; set; }
        public int TeamID { get; set; }
    }
}
