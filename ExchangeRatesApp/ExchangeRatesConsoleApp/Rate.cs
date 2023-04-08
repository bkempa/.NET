using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("EchangeRatesAppGUI")]
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
