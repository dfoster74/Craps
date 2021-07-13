using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BoZero.Craps.Application.WebApp.Data;

namespace BoZero.Craps.Application.WebApp.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
		private readonly ICrapsApiClient _crapsApiClient;

		public IndexModel(ICrapsApiClient crapsApiClient, ILogger<IndexModel> logger)
		{
			_crapsApiClient = crapsApiClient;
			_logger = logger;
		}

		public async void OnGet()
		{
			var cancellationTokenSource = new CancellationTokenSource();

			var roll = await _crapsApiClient.GetDice(cancellationTokenSource.Token);
		}
	}
}
