using System;
using System.Net.Http;
using System.Text;

namespace APIClient
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			using (var httpClient = new HttpClient())
			{
				var response = httpClient.GetAsync("http://localhost:55055/API/values").Result;

				Console.WriteLine("GET 1 -------");
				Console.WriteLine(response.Content.ReadAsStringAsync().Result);

				Console.WriteLine(string.Empty);

				response = httpClient.GetAsync("http://localhost:55055/API/values/12").Result;

				Console.WriteLine("GET 2 -------");
				Console.WriteLine(response.Content.ReadAsStringAsync().Result);

				Console.WriteLine(string.Empty);

				using (var stringContent = new StringContent(@"""content""", Encoding.UTF8, "application/json"))
				{
					response = httpClient.PostAsync("http://localhost:55055/API/values", stringContent).Result;
				}

				Console.WriteLine("POST -------");
				Console.WriteLine(response.Content.ReadAsStringAsync().Result);

				Console.WriteLine(string.Empty);

				using (var stringContent = new StringContent(@"""content""", Encoding.UTF8, "application/json"))
				{
					response = httpClient.PutAsync("http://localhost:55055/API/values/12", stringContent).Result;
				}

				Console.WriteLine("PUT -------");
				Console.WriteLine(response.Content.ReadAsStringAsync().Result);

				Console.WriteLine(string.Empty);

				using (var stringContent = new StringContent(@"""content""", Encoding.UTF8, "application/json"))
				{
					response = httpClient.DeleteAsync("http://localhost:55055/API/values/12").Result;
				}

				Console.WriteLine("DELETE -------");
				Console.WriteLine(response.Content.ReadAsStringAsync().Result);

				Console.WriteLine(string.Empty);

				response = httpClient.GetAsync("http://localhost:55055/API/values/filter?value=true").Result;

				Console.WriteLine("GET ROUTE -------");
				Console.WriteLine(response.Content.ReadAsStringAsync().Result);
			}

			Console.ReadKey();
		}
	}
}
