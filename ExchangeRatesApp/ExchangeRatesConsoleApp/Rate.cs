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
        public DateTime EffectiveDate { set; get; }
        public double Mid { set; get; }

        public Rate(DateTime date, double mid)
        {
            this.EffectiveDate = date;
            this.Mid = mid;
        }

        public override string ToString()
        {
            return "stan na " + EffectiveDate.ToShortDateString() + ": " + Mid.ToString() + " zł";
        }
    }
}
