using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRatesConsoleApp
{
    internal class Rate
    {
        public DateTime effectiveDate { set; get; }
        public double mid { set; get; }

        [JsonConstructor] public Rate(DateTime date, double mid)
        {
            this.effectiveDate = date;
            this.mid = mid;
        }

        public override string ToString()
        {
            return effectiveDate.ToShortDateString() + ": " + mid.ToString() + " zł";
        }
    }
}
