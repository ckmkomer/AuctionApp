using AuctionApp.Core.Dtos;
using AuctionApp.Core.Entities;
using AuctionApp.Core.Repositories;
using AuctionApp.Core.Services;
using AuctionApp.Core.UnitOfWork;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Service.Services
{
	public class Service<Entity, Dto> : IService<Entity, Dto> where Entity : BaseEntity where Dto : class
	{

		private readonly IGenericRepository<Entity> _repository;
		protected readonly IUnitOfWork _unitOfWork;
		protected readonly IMapper _mapper;

		public Service(IGenericRepository<Entity> repository, IUnitOfWork unitOfWork)
		{
			_repository = repository;
			_unitOfWork = unitOfWork;
		}

		public Service(IGenericRepository<Entity> repository, IUnitOfWork unitOfWork, IMapper mapper) : this(repository, unitOfWork)
		{
			_mapper = mapper;
		}

		public async Task<CustomResponseDto<Dto>> AddAsync(Dto dto)
		{
			Entity newEnntity= _mapper.Map<Entity>(dto);
			await _repository.AddAsync(newEnntity);
			await _unitOfWork.CommitAsync();
			var newDto= _mapper.Map<Dto>(newEnntity);
			return CustomResponseDto<Dto>.Success(StatusCodes.Status200OK,newDto);
		}

		public Task<CustomResponseDto<IEnumerable<Dto>>> AddRangeAsync(IEnumerable<Dto> dto)
		{
			throw new NotImplementedException();
		}

		public Task<CustomResponseDto<bool>> AnyAsync(Expression<Func<Entity, bool>> expression)
		{
			throw new NotImplementedException();
		}

		public Task<CustomResponseDto<IEnumerable<Dto>>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<CustomResponseDto<Dto>> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<CustomResponseDto<NoContentDto>> RemoveAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<CustomResponseDto<NoContentDto>> RemoveRangeAsync(IEnumerable<int> ids)
		{
			throw new NotImplementedException();
		}

		public Task<CustomResponseDto<NoContentDto>> UpdateAsync(Dto dto)
		{
			throw new NotImplementedException();
		}

		public Task<CustomResponseDto<IEnumerable<Dto>>> Where(Expression<Func<Entity, bool>> expression)
		{
			throw new NotImplementedException();
		}
	}
}
