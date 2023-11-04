using Gielda_biblioteka;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gielda_Biblioteka
{
    public class InstrumentInfoLimitowanyDostep : InstrumentInfo
    {
        private int _availableQuantity;
        private int _producedQuantity;
        private JednostkaMiaryEnum _measureUnit;
        private decimal _price;

        public InstrumentInfoLimitowanyDostep(InstrumentFinansowy instrument, DateTime lastActualisation, int availableQuantity, int producedQuantity, JednostkaMiaryEnum measureUnit, decimal price)
            : base(instrument, lastActualisation)
        {
            _availableQuantity = availableQuantity;
            _producedQuantity = producedQuantity;
            _measureUnit = measureUnit;
            _price = price;
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public JednostkaMiaryEnum MeasureUnit
        {
            get { return _measureUnit; }
            set { _measureUnit = value; }
        }

        public int ProducedQueantity
        {
            get { return _producedQuantity; }
            set { _producedQuantity = value; }
        }

        public int AvailableQuantity
        {
            get { return _availableQuantity; }
            set { _availableQuantity = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"Dostępna ilość: {_availableQuantity}; Wypuszczona ilość: {_producedQuantity}; Jednostka: {_measureUnit}; Cena: {_price}$ \n";
        }

        public override void info()
        {
            Console.WriteLine("Metoda po natpisaniu - Działa");
        }
    }
}
