using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("EchangeRatesAppGUI")]
namespace ExchangeRatesConsoleApp
{
    internal class CurrenciesDatabase : DbContext
    {
        public virtual DbSet<Currency> Currencies { get; set;}
    }
}
