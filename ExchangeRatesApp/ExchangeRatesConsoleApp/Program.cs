using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ExchangeRatesConsoleApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            string call, currencyCode, startDate, endDate;
            startDate = "2023-04-01";
            endDate = "2023-04-07";
            currencyCode = "USD";

            call = $"http://api.nbp.pl/api/exchangerates/rates/A/{currencyCode}/{startDate}/{endDate}/?format=json";
            var response = await client.GetAsync(call);
            if (response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                Currency currency = JsonConvert.DeserializeObject<Currency>(responseString);
                Console.WriteLine(currency.ToString());
            }
            else
            {
                Console.WriteLine("Brak danych dla wskazanej daty");
            }
            Console.ReadKey();
        }
    }
}
