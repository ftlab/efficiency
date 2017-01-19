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

        private readonly EffFunc<TVar, TData> _func;

        public EffMatrix(int deep, EffFunc<TVar, TData> func)
        {
            if (deep < 1) throw new ArgumentException(nameof(deep));
            if (func == null) throw new ArgumentNullException(nameof(func));
            _deep = deep;
            _func = func;
        }


        public void AddVar(TVar value, List<TData> data) => _data.Add(value, data);

        public bool RemoveVar(TVar value) => _data.Remove(value);

        public void AddIndicator(EffIndicator<TData> indicator) => _indicators.Add(indicator);

        public void AddIndicator(Func<TData, int> get) => AddIndicator(new EffIndicator<TData>(get));

        public bool RemoveIndicator(EffIndicator<TData> indicator) => _indicators.Remove(indicator);

        public TVar GetEffectiveVar(List<TVar> summ)
        {
            return _data
                .OrderByDescending(x => _func.Get(x.Key, summ, x.Value))
                .FirstOrDefault()
                .Key;
        }
    }


}
