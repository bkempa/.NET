using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRatesConsoleApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            string call, currencyCode, startDate, endDate;
            startDate = "2023-04-04";
            endDate = startDate;
            currencyCode = "USD";

            if (DateTime.Today.Equals(DateTime.Parse(startDate)))
                call = $"http://api.nbp.pl/api/exchangerates/rates/A/{currencyCode}/today/?format=json";
            else
                call = $"http://api.nbp.pl/api/exchangerates/rates/A/{currencyCode}/{startDate}/{endDate}/?format=json";
            string response = await client.GetStringAsync(call);

            ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(response);
            foreach (Rate rate in apiResponse.rates)
            {
                Console.WriteLine(rate.ToString());
            }
            Console.ReadKey();
        }
    }
}
