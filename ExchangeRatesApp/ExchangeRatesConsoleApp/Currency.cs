using System;
using System.Linq;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("EchangeRatesAppGUI")]
namespace ExchangeRatesConsoleApp
{
    internal class Currency
    {
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
        public Rate[] Rates { get; set; }


        public Currency(string currency, string code, Rate[] rates)
        {
            CurrencyName = currency;
            CurrencyCode = code;
            Rates = rates;
        }

        public override string ToString()
        {
            return this.CurrencyName + " (" + this.CurrencyCode + ")" + Environment.NewLine +"\t" + string.Join(Environment.NewLine + "\t", Rates.Select(r => r.ToString()).ToArray());
        }
    }
}
