using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gielda_Biblioteka
{
    public abstract class InstrumentFinansowy
    {
        private string _name;
        private string _symbol;

        public InstrumentFinansowy() { }
        public InstrumentFinansowy(string name, string symbol)
        {
            this._name = name;
            this._symbol = symbol;
        }



        public string Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public override string ToString()
        {
            return $"Nazwa: {_name}; Symbol: {_symbol} \n";
        }
    }
}