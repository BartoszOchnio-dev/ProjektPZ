using Gielda_Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gielda_biblioteka
{
    public class Surowiec : InstrumentFinansowy, Interface1
    {

		public Surowiec() { }
		public Surowiec(string name, string symbol)
			: base(name, symbol)
		{

		}

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
