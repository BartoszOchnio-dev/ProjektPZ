using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gielda_biblioteka
{
    public class Kryptowaluta : Waluta
    {
		private BlockchainEnum _blockchain;
		private DateTime _startDate;

		public Kryptowaluta() { }

		public Kryptowaluta(string name, string symbol, KrajEnum country, BlockchainEnum blockchainEnum, DateTime startDate)
			: base(name, symbol, country)
		{
			_blockchain = blockchainEnum;
			_startDate = startDate;
		}

		public DateTime StartDate
		{
			get { return _startDate; }
			set { _startDate = value; }
		}

		public BlockchainEnum Blockchain
		{
			get { return _blockchain; }
			set { _blockchain = value; }
		}

        public override string ToString()
        {
            return base.ToString() + $"Blockchain: {_blockchain}; Data utworzenia: {_startDate}\n";
        }
    }
}
