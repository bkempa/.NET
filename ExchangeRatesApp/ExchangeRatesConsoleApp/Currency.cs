using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRatesConsoleApp
{
    internal class Currency
    {
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
        public Rate[] Rates { get; set; }


        public Currency(string table, string currency, string code, Rate[] rates)
        {
            CurrencyName = currency;
            CurrencyCode = code;
            Rates = rates;
        }

        public override string ToString()
        {
            return this.CurrencyName + " (" + this.CurrencyCode + ")\n\t" + string.Join("\n\t", Rates.Select(r => r.ToString()).ToArray());
        }
    }
}
