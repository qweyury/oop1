using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ооп3
{
    public class AmericanDateTimeFormatter : IDateTimeFormatter
    {
        public string Format()
        {
            var cultureInfo = new CultureInfo("en-US");
            return DateTime.Now.ToString(cultureInfo);
        }
    }
}
