using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efficiency
{
    public class EffMatrix<TVar, TContext>
    {
        private readonly List<TVar> _variants = new List<TVar>();

        private readonly EffFunc<TVar, TContext> _func;

        public EffMatrix(EffFunc<TVar, TContext> func)
        {
            if (func == null) throw new ArgumentNullException(nameof(func));
            _func = func;
        }

        public void AddVar(TVar value) => _variants.Add(value);

        public bool RemoveVar(TVar value) => _variants.Remove(value);

        public TVar GetEffectiveVar(TContext context)
        {
            return _variants
                .OrderByDescending(x => _func.Calc(x, context))
                .FirstOrDefault();
        }
    }


}
