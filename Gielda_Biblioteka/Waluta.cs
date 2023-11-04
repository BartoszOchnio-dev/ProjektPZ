using Gielda_Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gielda_biblioteka
{
    public class Waluta : InstrumentFinansowy, Interface2
    {
		private KrajEnum _country;
		
		public Waluta() { }

		public Waluta(string name, string symbol, KrajEnum country)
			: base(name, symbol)
		{
			_country = country;

		}

		public KrajEnum Country
		{
			get { return _country; }
			set { _country = value; }
		}

        public override string ToString()
        {
            return base.ToString() + $"Kraj emisji: {_country}; \n";
        }
    }
}
