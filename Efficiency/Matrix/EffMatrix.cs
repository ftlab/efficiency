using System;
using System.Collections.Generic;
using System.Linq;

namespace Efficiency.Matrix
{
    /// <summary>
    /// Матрица эффективности
    /// </summary>
    /// <typeparam name="TVar">тип варианта</typeparam>
    /// <typeparam name="TContext">тип контекста</typeparam>
    public class EffMatrix<TVar, TContext>
        where TContext : IEffMatrixContext<TVar>
    {
        /// <summary>
        /// Функция эффективности
        /// </summary>
        private EffFunc<TVar, TContext> _func;

        /// <summary>
        /// Конструктор  матрицы эффективности
        /// </summary>
        /// <param name="func">функция эффективности</param>
        public EffMatrix(EffFunc<TVar, TContext> func)
        {
            if (func == null) throw new ArgumentNullException(nameof(func));
            _func = func;
        }

        /// <summary>
        /// Получить эффективный вариант
        /// </summary>
        /// <param name="context">контекст</param>
        /// <returns>вариант</returns>
        public TVar GetEffectiveVar(TContext context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));

            return context
                .Get()
                .OrderByDescending(x => _func.Calc(x, context))
                .FirstOrDefault();
        }
    }


}
