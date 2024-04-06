using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes.Solid.OdemeYontemiKotu
{
    public class KrediKarti
    {
        public bool krediKartiOdemeYap(double tutar)
        {
            Console.WriteLine("Kredi kartı ile " + tutar + " TL ödeme yapıldı.");
            return true;
        }
    }
}
