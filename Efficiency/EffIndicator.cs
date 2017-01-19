using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efficiency
{
    public class EffIndicator<T>
    {
        private readonly Func<T, int> _get;
        public EffIndicator(Func<T, int> get)
        {
            if (get == null) throw new ArgumentNullException();
            _get = get;
        }

        public int Get(T value) => _get(value);
    }
}
