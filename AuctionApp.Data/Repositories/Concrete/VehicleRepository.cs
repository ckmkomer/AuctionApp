using AuctionApp.Core.Entities;
using AuctionApp.Data.Data.Context;
using AuctionApp.Data.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Data.Repositories.Concrete
{
	public class VehicleRepository : GenericRepository<Vehicle>,IVehicleRepository
	{
		public VehicleRepository(AuctionAppDbContext appDbContext, DbSet<Vehicle> dbSet) : base(appDbContext, dbSet)
		{
		}
	}
}
