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
        /// Список вариантов
        /// </summary>
        private readonly IEnumerable<TVar> _variants;

        /// <summary>
        /// Функция эффективности
        /// </summary>
        private EffFunc<TVar, TContext> _func;

        /// <summary>
        /// Конструктор  матрицы эффективности
        /// </summary>
        /// <param name="func">функция эффективности</param>
        /// <param name="variants">варианты</param>
        public EffMatrix(EffFunc<TVar, TContext> func, IEnumerable<TVar> variants)
        {
            if (func == null) throw new ArgumentNullException(nameof(func));
            if (variants == null) throw new ArgumentNullException(nameof(variants));
            _func = func;
            _variants = variants;
        }

        /// <summary>
        /// Получить эффективный вариант
        /// </summary>
        /// <param name="context">контекст</param>
        /// <returns>вариант</returns>
        public TVar GetEffectiveVar(TContext context)
        {
            return _variants
                .OrderByDescending(x => _func.Calc(x, context))
                .FirstOrDefault();
        }
    }


}
