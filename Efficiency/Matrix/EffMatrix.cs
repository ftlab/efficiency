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
        /// Вычислить эффективность
        /// </summary>
        /// <param name="variant">вариант</param>
        /// <param name="context">контекст</param>
        /// <returns>значение эффективности</returns>
        public double CallEffective(TVar variant, TContext context) => _func.Calc(variant, context);

        /// <summary>
        /// Получить эффективный вариант
        /// </summary>
        /// /// <param name="variants">Варианты</param>
        /// <param name="context">контекст</param>
        /// <returns>вариант</returns>
        public TVar GetEffectiveVar(IEnumerable<TVar> variants, TContext context)
        {
            return variants
                .OrderByDescending(x => CallEffective(x, context))
                .FirstOrDefault();
        }
    }


}
