using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.WebSockets;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using BoZero.Craps.Business.Core.Entities;

namespace BoZero.Craps.Application.WebApp.Data
{
	public class CrapsApiClient : ICrapsApiClient
	{
		private readonly HttpClient _httpClient;

		public CrapsApiClient(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<Roll> GetDice(CancellationToken cancellationToken)
		{
			var request = new HttpRequestMessage(HttpMethod.Get, "api/craps");
			request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json", 1.0));

			try
			{
				using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
				response.EnsureSuccessStatusCode();
				var content = await response.Content.ReadAsStringAsync(cancellationToken);
				return JsonSerializer.Deserialize<Roll>(content, new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
			}
			catch (OperationCanceledException e)
			{
				Console.WriteLine($"An operation was cancelled with message {e.Message}.");
				throw;
			}
		}
	}
}
