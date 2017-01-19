using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efficiency
{
    public class EffMatrix<TVar, TData>
    {
        private readonly int _deep;

        private readonly List<EffIndicator<TData>> _indicators = new List<EffIndicator<TData>>();

        private readonly Dictionary<TVar, List<TData>> _data = new Dictionary<TVar, List<TData>>();

        public EffMatrix(int deep)
        {
            if (deep < 1) throw new ArgumentException(nameof(deep));
            _deep = deep;
        }

        public void AddIndicator(EffIndicator<TData> indicator) => _indicators.Add(indicator);

        public void AddIndicator(Func<TData, int> get) => AddIndicator(new EffIndicator<TData>(get));

        public bool RemoveIndicator(EffIndicator<TData> indicator) => _indicators.Remove(indicator);

        public TVar GetEffectiveVar(TVar[] summ)
        {
            return default(TVar);
        }
    }


}
