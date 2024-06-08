using AuctionApp.Core.Dtos;

using AuctionApp.Core.Dtos.AppUserDtos;
using AuctionApp.Core.Dtos.VehicleDtos;
using AuctionApp.Core.Entities;
using AuctionApp.Core.Entities.Identity;
using AuctionApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Service.Services.Abstract
{
	public interface IUserService
	{
		Task<CustomResponseDto<NoContentDto>> Register(RegisterRequestDto registerRequest);
		Task<CustomResponseDto<NoContentDto>> Login(LoginRequestDto  loginRequest);

	}
}
