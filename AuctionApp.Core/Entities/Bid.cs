using AuctionApp.Core.Entities.Identity;
using AuctionApp.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Core.Entities
{
	public class Bid :BaseEntity
	{
        public decimal BidAmount { get; set; }
        public DateTime BidDate { get; set; }
       public string BidStatus { get; set;}= BidStatusEnum.Pending.ToString();

        public string UserId { get; set; }
        public AppUser AppUser { get; set; }

        public int BidId { get; set; }
        public Vehicle Vehicle { get; set; }

    }
}
