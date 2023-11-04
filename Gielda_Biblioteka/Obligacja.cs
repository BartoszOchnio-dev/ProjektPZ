using Gielda_Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gielda_biblioteka
{
    public class Obligacja : InstrumentFinansowy, Interface1
    {

		private decimal _interestRate;
		private TypObligacjiEnum _bondType;
		private int _lengthInMonths;



		public Obligacja() { }
		public Obligacja(string name, string symbol, decimal interestRate, TypObligacjiEnum bondType, int lengthInMonght)
			: base(name, symbol)
		{
			_interestRate = interestRate;
			_bondType = bondType;
			_lengthInMonths = lengthInMonght;

		}

        public int LengthInMonths
        {
            get { return _lengthInMonths; }
            set { _lengthInMonths = value; }
        }
        public TypObligacjiEnum BonType
		{
			get { return _bondType; }
			set { _bondType = value; }
		}
		public decimal InterestRate
		{
			get { return _interestRate; }
			set { _interestRate = value; }
		}


        public override string ToString()
        {
			return base.ToString() + $"Oprocentowanie: {_interestRate}; Rodzaj obligacji: {_bondType}; Okres(miesiące): {_lengthInMonths} \n";
        }

    }
}
