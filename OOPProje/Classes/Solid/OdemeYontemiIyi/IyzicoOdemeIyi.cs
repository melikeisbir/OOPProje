using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes.Solid.OdemeYontemiIyi
{
    public class IyzicoOdemeIyi : IOdemeType
    {
        public string OdemeYapma(double tutar)
        {
            return "Iyzico ile " + tutar + " TL ödeme yapıldı";
        }
    }
}
