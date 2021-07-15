using BoZero.Craps.Business.Core.Entities;
using BoZero.Craps.Business.Core.Interfaces;

namespace BoZero.Craps.Business.Core.Services
{
	public class RollService : IRollService
	{
		private readonly IRandomNumberService _randomNumberService;

		//private readonly ILogger<RollService> _logger;

		//public RollService(IRandomNumberService randomNumberService, ILogger<RollService> logger)
		public RollService(IRandomNumberService randomNumberService)
		{
			_randomNumberService = randomNumberService;
			//_logger = logger;
		}

		public Roll GetRoll()
		{
			var die1 = _randomNumberService.GetRandomNumber(6) + 1;
			var die2 = _randomNumberService.GetRandomNumber(6) + 1;
			//_logger.LogDebug($"Roll: {die1}, {die2}");
			return new Roll(die1, die2);
		}
	}
}
