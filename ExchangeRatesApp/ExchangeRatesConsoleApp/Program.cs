using Newtonsoft.Json;
using System;
using System.Net.Http;
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
            string response = await client.GetStringAsync(call);
            Currency currency = JsonConvert.DeserializeObject<Currency>(response);
            Console.WriteLine(currency.ToString());
            Console.ReadKey();
        }
    }
}
