﻿using AuctionApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Core.Repositories
{
	public interface IGenericRepository< T> where T : BaseEntity
	{
		Task<T> GetByIdAsync(int id);

		IQueryable<T> GetAll(Expression<Func<T, bool>> expression);

		IQueryable<T> Where(Expression<Func<T, bool>> expression);

		Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
		Task AddAsync(T entity);

		void Add(T entity);

		Task AddRangeAsync(IEnumerable<T> entities);

		void Update(T entity);

		void Remove(T entity);

		void RemoveRange(IEnumerable<T> entities);
	}
}

