using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gielda_Biblioteka
{
    public class InstrumentTransakcja
    {
		private InstrumentFinansowy _instrument;
        private decimal _purchasePrice;
        private int _amount;
		private DateTime _purchaseDate;

		public InstrumentTransakcja() { }
        public InstrumentTransakcja(InstrumentFinansowy instrument, decimal purchasePrice, int amount, DateTime purchaseDate)
        {
            _instrument = instrument;
            _purchasePrice = purchasePrice;
            _amount = amount;
            _purchaseDate = purchaseDate;
        }

        public DateTime PurchaseDate
		{
			get { return _purchaseDate; }
			set { _purchaseDate = value; }
		}

		public decimal PurchasePrice
		{
			get { return _purchasePrice; }
			set { _purchasePrice = value; }
		}

		public int Amount
		{
			get { return _amount; }
			set { _amount = value; }
		}

		public InstrumentFinansowy Instrument
		{
			get { return _instrument; }
			set { _instrument = value; }
		}

	}
}
