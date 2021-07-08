using System;
using BoZero.Craps.Business.Core.Entities;
using BoZero.Craps.Business.Core.Interfaces;

namespace BoZero.Craps.Business.Core.Services
{
	public class RollService : IRollService
	{
		public Roll GetRoll()
		{
			var rng = new Random();
			var die1 = rng.Next(6) + 1;
			var die2 = rng.Next(6) + 1;
			return new Roll(die1, die2);
		}
	}
}
