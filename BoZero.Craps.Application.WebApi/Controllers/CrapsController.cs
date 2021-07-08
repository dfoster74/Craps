using AutoMapper;
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
		private readonly IMapper _mapper;

		public CrapsController(IRollService rollService, IMapper mapper)
		{
			_rollService = rollService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult GetDice()
		{
			var roll = _rollService.GetRoll();

			var rollModel = _mapper.Map<RollModel>(roll);
			return Ok(rollModel);
		}
	}
}
