using AuctionApp.Core.Dtos.VehicleDtos;
using AuctionApp.Core.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Service.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Vehicle,CreateVehicleDto>().ReverseMap();
			CreateMap<Vehicle, UpdateVehicleDto>().ReverseMap();
			CreateMap<Vehicle, ResultVehicleDto>().ReverseMap();
			CreateMap<Vehicle, GetByIdVehicleDto>().ReverseMap();
			CreateMap<Vehicle, VehicleDto>().ReverseMap();
		}
	}
}
