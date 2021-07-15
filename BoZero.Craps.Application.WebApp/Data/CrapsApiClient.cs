using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using BoZero.Craps.Business.Core.Entities;
using Microsoft.Extensions.Logging;

namespace BoZero.Craps.Application.WebApp.Data
{
	public class CrapsApiClient : ICrapsApiClient
	{
		private readonly HttpClient _httpClient;

		private readonly ILogger<CrapsApiClient> _logger;

		public CrapsApiClient(HttpClient httpClient, ILogger<CrapsApiClient> logger)
		{
			_logger = logger;
			_httpClient = httpClient;
		}

		public async Task<Roll> GetDice(CancellationToken cancellationToken)
		{
			var request = new HttpRequestMessage(HttpMethod.Get, "api/craps");
			request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

			try
			{
				using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
				response.EnsureSuccessStatusCode();
				await using var stream = await response.Content.ReadAsStreamAsync(cancellationToken);
				return await JsonSerializer.DeserializeAsync<Roll>(stream, new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase}, cancellationToken);
			}
			catch (OperationCanceledException e)
			{
				_logger.LogError($"$Cancellation: {e.Message}");
				throw;
			}
		}
	}
}
