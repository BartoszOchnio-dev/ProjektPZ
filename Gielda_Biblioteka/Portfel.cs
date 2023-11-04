using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gielda_Biblioteka
{
    public class Portfel : Uzytkownik
    {
		private List<InstrumentTransakcja> _instruments;

        public Portfel() { }
        public Portfel(int id, string firstName, string lastName)
            : base(id, firstName, lastName)
        {
            _instruments = new List<InstrumentTransakcja>();
        }

        public List<InstrumentTransakcja> Instruments
		{
			get { return _instruments; }
			set { _instruments = value; }
		}

        public void addTransaction(InstrumentTransakcja instrument)
        {
            _instruments.Add(instrument);
        }
        

	}
}
