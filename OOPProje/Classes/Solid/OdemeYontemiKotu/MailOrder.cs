using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes.Solid.OdemeYontemiKotu
{
    public class MailOrder
    {
        public bool mailOrderOde(double fiyat)
        {
            Console.WriteLine("Mail Order ile " + fiyat + " TL ödeme yapıldı.");
            return true;
        }
    }
}
