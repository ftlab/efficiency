using System;
using System.Collections.Generic;
using System.Linq;

namespace Efficiency
{
    public class EffFunc<TVar, TContext>
    {
        private readonly List<EffIndicator<TVar, TContext>> _indicators = new List<EffIndicator<TVar, TContext>>();

        private readonly Func<IEnumerable<double>, double> _func;

        public EffFunc(Func<IEnumerable<double>, double> func)
        {
            if (func == null) throw new ArgumentNullException(nameof(func));
            _func = func;
        }

        public double Calc(TVar var, TContext context)
            => _func(_indicators.Select(x => x.Get(var, context)));

        public void AddIndicator(EffIndicator<TVar, TContext> indicator) => _indicators.Add(indicator);

        public void AddIndicator(Func<TVar, TContext, double> func) => AddIndicator(new EffIndicator<TVar, TContext>(func));

        public bool RemoveIndicator(EffIndicator<TVar, TContext> indicator) => _indicators.Remove(indicator);

    }
}
