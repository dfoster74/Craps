using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using BoZero.Craps.Business.Core.Entities;

namespace BoZero.Craps.Application.WebApp.Data
{
	public class CrapsApiClient
	{
		private static HttpClient _httpClient = new HttpClient();

		public CrapsApiClient()
		{
			_httpClient.BaseAddress = new Uri("http://localhost:14401");
			_httpClient.Timeout = new TimeSpan(0, 0, 30);
			_httpClient.DefaultRequestHeaders.Clear();
			_httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json", 1.0));
		}

		public async Task GetDice()
		{
			var response = await _httpClient.GetAsync(("api/craps")).ConfigureAwait(false);
			response.EnsureSuccessStatusCode();
			if (response.Content.Headers.ContentType != null && response.Content.Headers.ContentType.MediaType == "application/json")
			{
				var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
				var data2 = JsonSerializer.Deserialize<Roll>(content, new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
			}
		}
	}
}
