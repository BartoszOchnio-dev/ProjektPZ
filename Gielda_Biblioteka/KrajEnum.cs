using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gielda_biblioteka
{
    public enum KrajEnum
    {
        [Description("Stany Zjednoczone")]
        USA,           // Dolar amerykański (USD)
        [Description("Strefa Euro")]
        Eurozone,      // Euro (EUR)
        [Description("Japonia")]
        Japan,         // Japoński jen (JPY)
        [Description("Wielka Brytania")]
        UnitedKingdom, // Funt szterling (GBP)
        [Description("Szwajcaria")]
        Switzerland,   // Frank szwajcarski (CHF)
        [Description("Kanada")]
        Canada,        // Dolar kanadyjski (CAD)
        [Description("Australia")]
        Australia,     // Dolar australijski (AUD)
        [Description("Nowa Zelandia")]
        NewZealand,    // Dolar nowozelandzki (NZD)
        [Description("Chiny")]
        China,         // Chiński juan (CNY)
        [Description("Indie")]
        India,         // Indyjska rupia (INR)
        [Description("Polska")]
        Poland,       // Złotówka (PLN)
        [Description("Emisja Ogólnoświatowa")]
        All        

    }
}
