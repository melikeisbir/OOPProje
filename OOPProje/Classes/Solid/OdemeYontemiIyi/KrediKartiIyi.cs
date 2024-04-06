using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes.Solid.OdemeYontemiIyi
{
    public class KrediKartiIyi : IOdemeType
    {
        public string OdemeYapma(double tutar)
        {
            return "Kredi kartı ile " + tutar + " TL ödeme yapıldı";
        }
    }
}
