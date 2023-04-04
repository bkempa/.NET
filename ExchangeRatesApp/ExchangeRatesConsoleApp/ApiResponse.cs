using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRatesConsoleApp
{
    internal class ApiResponse
    {
        public string table { get; set; }
        public string currency { get; set; }
        public string code { get; set; }
        public Rate[] rates { get; set; }
        
        [JsonConstructor] public ApiResponse(string table, string currency, string code, Rate[] rates) 
        {
            this.table = table;
            this.currency = currency;
            this.code = code;
            this.rates = rates;
        }
    }
}
