using AuctionApp.Core.Entities;
using AuctionApp.Core.Repositories;
using AuctionApp.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Data.Repositories
{
    public class GenericRepository<T> :IGenericRepository<T> where T : BaseEntity
	{
		private readonly AuctionAppDbContext _appDbContext;
		private readonly DbSet<T> _dbSet;

		public GenericRepository(AuctionAppDbContext appDbContext, DbSet<T> dbSet)
		{
			_appDbContext = appDbContext;
			_dbSet = _appDbContext.Set<T>();
		}

		public void Add(T entity)
		{
			_dbSet.Add(entity);

		}

		public async Task AddAsync(T entity)
		{
			await _dbSet.AddAsync(entity);
		}

		public async Task AddRangeAsync(IEnumerable<T> entities)
		{
			await _dbSet.AddRangeAsync(entities);
		}

		public async Task<bool> Any(Expression<Func<T, bool>> expression)
		{
			return await _dbSet.AnyAsync(expression);
		}

		public Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
		{
			throw new NotImplementedException();
		}

		public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
		{
			return _dbSet.AsNoTracking().AsQueryable();
		}

		public async Task<T> GetByIdAsync(int id)
		{
			return await _dbSet.FirstAsync(x => x.Id == id);
		}

		public void Remove(T entity)
		{
			_dbSet.Remove(entity);
		}

		public void RemoveRange(IEnumerable<T> entities)
		{
			_dbSet.RemoveRange(entities);
		}

		public void Update(T entity)
		{
			_dbSet.Update(entity);
		}

		public IQueryable<T> Where(Expression<Func<T, bool>> expression)
		{
			return _dbSet.Where(expression);
		}

	}
}
