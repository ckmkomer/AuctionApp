using AuctionApp.Core.Dtos;
using AuctionApp.Core.Dtos.AppUserDtos;
using AuctionApp.Core.Entities.Identity;
using AuctionApp.Data.Context;
using AuctionApp.Service.Services.Abstract;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Service.Services.Concrete
{
    public class UserService : IUserService
	{
		private readonly AuctionAppDbContext _auctionAppDb;
		private readonly IMapper _mapper;
		private readonly UserManager<AppUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		public string secretKey;

		public UserService(RoleManager<IdentityRole> roleManager,UserManager<AppUser> userManager, IMapper mapper, IConfiguration _configuration,AuctionAppDbContext auctionAppDb)
		{
			_userManager = userManager;
			_mapper = mapper;
			_auctionAppDb = auctionAppDb;
			_roleManager = roleManager;
			secretKey = _configuration.GetValue<string>("SecretKey:jwtKey");
		}

		public Task<CustomResponseDto<NoContentDto>> Login(LoginRequestDto loginRequest)
		{
			throw new NotImplementedException();
		}

		public Task<CustomResponseDto<NoContentDto>> Register(RegisterRequestDto registerRequest)
		{
			throw new NotImplementedException();
		}
	}
}
