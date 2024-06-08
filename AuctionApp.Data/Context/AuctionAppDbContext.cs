using AuctionApp.Core.Entities;
using AuctionApp.Core.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Data.Context
{
    public class AuctionAppDbContext : IdentityDbContext<AppUser>
    {
		
		public AuctionAppDbContext(DbContextOptions options) : base(options)
        {
        }

		

		
        public DbSet<Vehicle> Vehicles { get; set; }
       
    }
}
