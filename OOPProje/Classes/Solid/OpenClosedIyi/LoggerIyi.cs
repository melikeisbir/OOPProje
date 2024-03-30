using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes.Solid.OpenClosedIyi
{
    public class LoggerIyi 
    {
        public ILogger ILogger;
        public LoggerIyi(ILogger ıLogger)
        {
            ILogger = ıLogger;
        }

        public string LogKayit(string value)
        {
            return ILogger.Log(value);
        }
    }
}
