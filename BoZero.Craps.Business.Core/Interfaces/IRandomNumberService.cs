using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoZero.Craps.Business.Core.Interfaces
{
	public interface IRandomNumberService
	{
		public int GetRandomNumber(int maxValue);
	}
}
