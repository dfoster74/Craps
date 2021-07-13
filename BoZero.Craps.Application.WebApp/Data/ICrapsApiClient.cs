using System.Threading;
using System.Threading.Tasks;
using BoZero.Craps.Business.Core.Entities;

namespace BoZero.Craps.Application.WebApp.Data
{
	public interface ICrapsApiClient
	{
		public Task<Roll> GetDice(CancellationToken cancellationToken);
	}
}
