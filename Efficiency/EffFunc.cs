using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efficiency
{
    public class EffFunc<T>
    {
        private Func<T, int> _calc;
        public EffFunc(Func<T, int> calc)
        {
            if (calc == null) throw new ArgumentNullException(nameof(calc));
            _calc = calc;
        }

        public int Calc(T value) => _calc(value);
    }
}
