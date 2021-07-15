using System;
using BoZero.Craps.Business.Core.Interfaces;
using Microsoft.Extensions.Logging;

namespace BoZero.Craps.Business.Core.Services
{
	public class RandomNumberService : IRandomNumberService
	{
		private readonly ILogger<RandomNumberService> _logger;

		private readonly Random _rng = new Random();

		public RandomNumberService(ILogger<RandomNumberService> logger)
		{
			_logger = logger;
		}

		public int GetRandomNumber(int maxValue)
		{
			var result = _rng.Next(maxValue);
			_logger.LogDebug($"Random Number Selected: {result}");
			return result;
		}
	}
}
