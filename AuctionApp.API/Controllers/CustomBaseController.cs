﻿using AuctionApp.Core.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuctionApp.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomBaseController : ControllerBase
	{
		[NonAction]
		public IActionResult CreateActionResult<T>(CustomResponseDto<T> responseDto)
		{
			if (responseDto.StatusCode == 204)
				return new ObjectResult(null)
				{
					StatusCode = responseDto.StatusCode
				};
			return new ObjectResult(responseDto)
			{
				StatusCode = responseDto.StatusCode
			};
		}
	}
}
