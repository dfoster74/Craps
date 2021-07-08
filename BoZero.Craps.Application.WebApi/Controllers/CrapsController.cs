using BoZero.Craps.Application.WebApi.Models;
using BoZero.Craps.Business.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BoZero.Craps.Application.WebApi.Controllers
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
