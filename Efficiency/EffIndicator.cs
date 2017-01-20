using System;

namespace Efficiency
{
    public class EffIndicator<TVar, TContext>
    {
        private Func<TVar, TContext, double> _func;

        public EffIndicator(Func<TVar, TContext, double> func)
        {
            if (func == null) throw new ArgumentNullException(nameof(func));
            _func = func;
        }

        public double Get(TVar var, TContext context) => _func(var, context);
    }
}
