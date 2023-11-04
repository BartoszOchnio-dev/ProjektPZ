using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gielda_biblioteka
{
    public enum TypObligacjiEnum
    {
        [Description("Rządowa")]
        Government,
        [Description("Korporacyjna")]
        Corporate,
        [Description("Komunalna")]
        Municipal
    }

}
