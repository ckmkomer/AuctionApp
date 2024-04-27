using AuctionApp.Core.Dtos;
using AuctionApp.Core.Dtos.VehicleDtos;
using AuctionApp.Core.Entities;
using AuctionApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Service.Services.Abstract
{
	public interface IVehicleService :IGenericService<Vehicle,VehicleDto>
	{
		Task<CustomResponseDto<NoContentDto>> UpdateAsync(UpdateVehicleDto updateVehicleDto);
		Task<CustomResponseDto<VehicleDto>> AddAsync(CreateVehicleDto createVehicleDto);
	




	}
}
