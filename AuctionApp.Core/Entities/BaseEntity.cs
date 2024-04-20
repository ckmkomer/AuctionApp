using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Core.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }= DateTime.Now;
        public DateTime UpdateDate { get; set; }
        public DateTime DeletionDate { get; set; }
    }
}
