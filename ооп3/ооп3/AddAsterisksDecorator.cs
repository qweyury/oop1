using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ооп3
{
    public class AddAsterisksDecorator : DateTimeDecorator
    {
        public AddAsterisksDecorator(IDateTimeFormatter inner) : base(inner) { }

        public override string Format()
        {
            return $"* {_inner.Format()}  *";
        }
    }
}
