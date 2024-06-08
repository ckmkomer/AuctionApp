using AuctionApp.Core.Dtos;
using AuctionApp.Core.Dtos.VehicleDtos;
using AuctionApp.Core.Entities;
using AuctionApp.Core.Repositories;
using AuctionApp.Core.UnitOfWork;
using AuctionApp.Data.Repositories.Abstract;
using AuctionApp.Service.Services.Abstract;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Service.Services.Concrete
{
	public class VehicleService : GenericService<Vehicle, VehicleDto>, IVehicleService
	{
		private readonly IVehicleRepository _vehicleRepository;



		public VehicleService(IGenericRepository<Vehicle> repository, IUnitOfWork unitOfWork, IMapper mapper, IVehicleRepository vehicleRepository) : base(repository, unitOfWork, mapper)
		{
			_vehicleRepository = vehicleRepository;
		}


		public async Task<CustomResponseDto<VehicleDto>> AddAsync(CreateVehicleDto createVehicleDto)
		{
			
		    var newEntity = _mapper.Map<Vehicle>(createVehicleDto);
			await _vehicleRepository.AddAsync(newEntity);
			await _unitOfWork.CommitAsync();

			var newDto = _mapper.Map<VehicleDto>(newEntity);
			return CustomResponseDto<VehicleDto>.Success(StatusCodes.Status200OK, newDto);
		}

		
		public async Task<CustomResponseDto<NoContentDto>> UpdateAsync(UpdateVehicleDto updateVehicleDto)
		{
			var entity = _mapper.Map<Vehicle>(updateVehicleDto);
			_vehicleRepository.Update(entity);
			await _unitOfWork.CommitAsync();
			return CustomResponseDto<NoContentDto>.Success(StatusCodes.Status204NoContent);
		}
	}
}
