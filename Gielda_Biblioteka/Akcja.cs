using Gielda_Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gielda_biblioteka
{
    public class Akcja : InstrumentFinansowy, Interface1
    {
        private string _companyName;
        private decimal _dividend;



        public Akcja() { }
        public Akcja(string name, string symbol, string companyName, decimal dividend)
            : base(name, symbol)
        {
            _companyName = companyName;
            _dividend = dividend;

        }

        public decimal Dividend
        {
            get { return _dividend; }
            set { _dividend = value; }
        }

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }


        public override string ToString()
        {
            return base.ToString() + $"Firma: {_companyName}; Dividenda: {_dividend}; \n";
        }

    }
}
