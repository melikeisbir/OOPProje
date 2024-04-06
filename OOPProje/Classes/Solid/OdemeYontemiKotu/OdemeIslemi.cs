using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes.Solid.OdemeYontemiKotu
{
    public class OdemeIslemi
    {
        private KrediKarti krediKarti;
        private MailOrder mailOrder;
        public OdemeIslemi(KrediKarti krediKarti, MailOrder mailOrder)
        {
            this.krediKarti = krediKarti;
            this.mailOrder = mailOrder;
        }
        public void OdemeYap(OdemeType type, double tutar)
        {
            switch (type){
                case OdemeType.KrediKarti:
                    krediKarti.krediKartiOdemeYap(tutar);
                    break;
                case OdemeType.MailOrder:
                    mailOrder.mailOrderOde(tutar);
                    break;
            }
        }
    }
}
