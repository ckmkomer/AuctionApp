using AuctionApp.Core.Dtos.VehicleDtos;
using AuctionApp.Core.Entities;
using AuctionApp.Service.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuctionApp.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class VehicleController : CustomBaseController
	{
		private readonly IVehicleService _vehicleService;

		public VehicleController(IVehicleService vehicleService)
		{
			_vehicleService = vehicleService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			return CreateActionResult(await _vehicleService.GetAllAsync());
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			return CreateActionResult(await _vehicleService.GetByIdAsync(id));
		}

		[HttpPost]
		public async Task<IActionResult> Add(CreateVehicleDto createVehicle)
		{
			return CreateActionResult(await _vehicleService.AddAsync(createVehicle));
		}

		[HttpPut]
		public async Task<IActionResult> Update(UpdateVehicleDto updateVehicle)
		{
			return CreateActionResult(await _vehicleService.UpdateAsync(updateVehicle));
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> Remove(int id) 
		{
		   	return CreateActionResult(await _vehicleService.RemoveAsync(id));
		}

	    
	}
}
