﻿using AuctionApp.Core.UnitOfWork;
using AuctionApp.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
	{
		private readonly AuctionAppDbContext _auctionApp;

		public UnitOfWork(AuctionAppDbContext auctionApp)
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
