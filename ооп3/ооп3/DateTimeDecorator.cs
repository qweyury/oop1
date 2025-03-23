using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ооп3
{
    public class DateTimeDecorator : IDateTimeFormatter
    {
        protected readonly IDateTimeFormatter _inner;

        public DateTimeDecorator(IDateTimeFormatter inner)
        {
            _inner = inner;
        }

        public virtual string Format()
        {
            return _inner.Format();
        }
    }
}
