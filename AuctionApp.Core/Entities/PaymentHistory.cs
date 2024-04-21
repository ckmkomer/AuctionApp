using AuctionApp.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Core.Entities
{
	public class PaymentHistory :BaseEntity
	{
		public bool IsActive { get; set; }
       public DateTime PayDate { get; set; }

		public string UserId { get; set; }
		public AppUser User { get; set; }

		public int VhicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
