using OOPProje.Classes.Solid.OpenClosedIyi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes.Solid.OdemeYontemiIyi
{
    public class MailOrderIyi : IOdemeType
    {

        public string OdemeYapma(double tutar)
        {
            return "Mail Order ile " + tutar + " TL ödeme yapıldı";
        }
    }
}
