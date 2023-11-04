using Gielda_biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gielda_Biblioteka
{
    public class InstrumentInfo
    {
        private InstrumentFinansowy _instrument;
        private DateTime _lastActualisation;


        public InstrumentInfo(){}

        public InstrumentInfo(InstrumentFinansowy instrument,DateTime lastActualisation)
        {
            _instrument = instrument;
            _lastActualisation = lastActualisation;
        }

        public DateTime LastActualisation
        {
            get { return _lastActualisation; }
            set { _lastActualisation = value; }
        }


        public InstrumentFinansowy Instrument
        {
            get { return _instrument; }
            set { _instrument = value; }
        }


        public override string ToString()
        {
            return _instrument.ToString() +  $"Data aktualizacji: {_lastActualisation}\n";
        }

        public virtual void info() {
            Console.WriteLine("Klasa bazaowa - info");
        }

    }
}
