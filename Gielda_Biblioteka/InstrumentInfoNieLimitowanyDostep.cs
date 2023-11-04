using Gielda_biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gielda_Biblioteka
{
    public class InstrumentInfoNieLimitowanyDostep: InstrumentInfo, Interface2
    {
        private decimal _exchangeRateToUSD;

        public InstrumentInfoNieLimitowanyDostep(InstrumentFinansowy instrument, DateTime lastActualisation, decimal exchangeRateToUSD)
            :base(instrument,lastActualisation)
        {
            ExchangeRateToUSD = exchangeRateToUSD;
        }

        public decimal ExchangeRateToUSD
        {
            get { return _exchangeRateToUSD; }
            set { _exchangeRateToUSD = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"Kurs względem dolara: {_exchangeRateToUSD}\n";
        }

    }
}
