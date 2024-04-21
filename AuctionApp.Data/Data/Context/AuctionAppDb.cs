using AuctionApp.Core.Entities;
using AuctionApp.Core.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Data.Data.Context
{
    public class AuctionAppDb : IdentityDbContext<AppUser>
    {
        public AuctionAppDb(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
