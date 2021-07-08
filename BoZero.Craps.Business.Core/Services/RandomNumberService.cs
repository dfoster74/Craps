using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BoZero.Craps.Business.Core.Interfaces;

namespace BoZero.Craps.Business.Core.Services
{
	public class RandomNumberService : IRandomNumberService
	{
		private readonly Random _rng = new Random();

		public int GetRandomNumber(int maxValue)
		{
			return _rng.Next(maxValue);
		}
	}
}
