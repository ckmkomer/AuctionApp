using AuctionApp.Core.UnitOfWork;
using AuctionApp.Data.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
	{
		private readonly AuctionAppDb _auctionApp;

		public UnitOfWork(AuctionAppDb auctionApp)
		{
			_auctionApp = auctionApp;
		}

		public void Commit()
		{
			_auctionApp.SaveChanges();
		}

		public async Task CommitAsync()
		{
		await	_auctionApp.SaveChangesAsync();
		}
	}
}
