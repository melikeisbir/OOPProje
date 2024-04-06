using OOPProje.Classes.Solid.OpenClosedIyi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes.Solid.OdemeYontemiIyi
{
    public class OdemeIslemiIyi
    {
        public IOdemeType iOdemeType;
        public OdemeIslemiIyi(IOdemeType iOdemeType)
        {
            this.iOdemeType = iOdemeType;
        }
        public string OdemeYap(double tutar)
        {
            return iOdemeType.OdemeYapma(tutar);
        }
    }
}
