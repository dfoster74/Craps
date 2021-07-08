using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoZero.Application.WebApi.Craps.Models;

namespace BoZero.Application.WebApi.Craps.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CrapsController : ControllerBase
	{
		[HttpGet]
		public IActionResult GetDice()
		{
			var rng = new Random();
			//var roll = new {Die1 = rng.Next(6) + 1, Die2 = rng.Next(6) + 1 };
			var rollModel = new RollModel {Die1 = rng.Next(6) + 1, Die2 = rng.Next(6) + 1};
			return Ok(rollModel);
		}
	}
}
