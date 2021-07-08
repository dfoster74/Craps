using System;
using System.Runtime.CompilerServices;
using BoZero.Craps.Business.Core.Entities;
using BoZero.Craps.Business.Core.Interfaces;

namespace BoZero.Craps.Business.Core.Services
{
	public class RollService : IRollService
	{
		private readonly IRandomNumberService _randomNumberService;

		public RollService(IRandomNumberService randomNumberService)
		{
			_randomNumberService = randomNumberService;
		}

		public Roll GetRoll()
		{
			var die1 = _randomNumberService.GetRandomNumber(6) + 1;
			var die2 = _randomNumberService.GetRandomNumber(6) + 1;
			return new Roll(die1, die2);
		}
	}
}
