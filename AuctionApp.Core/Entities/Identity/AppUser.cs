using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Core.Entities.Identity
{
    public class AppUser :IdentityUser
    {
        public string  FullName { get; set; }
		public string ProfilePicture { get; set; }
		public string DateOfBirth { get; set; }

		public ICollection<PaymentHistory> paymentHistories { get; set; }
		public ICollection<Vehicle> vehicles { get; set; }
		public ICollection<Bid> Bids { get; set; }
	}
}
