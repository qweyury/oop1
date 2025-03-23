using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ооп3
{
    public class EuropeanDateTimeFormatter : IDateTimeFormatter
    {
        public string Format()
        {
            var cultureInfo = new CultureInfo("en-GB");
            return DateTime.Now.ToString(cultureInfo);
        }
    }
}
