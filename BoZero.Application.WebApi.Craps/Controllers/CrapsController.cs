using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;
using BoZero.Application.WebApi.Craps.Models;
using BoZero.Craps.Business.Core.Interfaces;

namespace BoZero.Application.WebApi.Craps.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CrapsController : ControllerBase
	{
		private readonly IRollService _rollService;

		public CrapsController(IRollService rollService)
		{
			_rollService = rollService;
		}

		[HttpGet]
		public IActionResult GetDice()
		{
			var roll = _rollService.GetRoll();
			var rollModel = new RollModel {Die1 = roll.Die1, Die2 = roll.Die2};
			return Ok(rollModel);
		}
	}
}
