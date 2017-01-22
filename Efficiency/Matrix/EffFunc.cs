using System;
using System.Collections.Generic;
using System.Linq;

namespace Efficiency.Matrix
{
    /// <summary>
    /// Функция эффективности
    /// </summary>
    /// <typeparam name="TVar">тип варианта</typeparam>
    /// <typeparam name="TContext">тип контекста</typeparam>
    public class EffFunc<TVar, TContext>
        where TContext: IEffMatrixContext<TVar>
    {
        /// <summary>
        /// Индикаторы эффективности
        /// </summary>
        private readonly List<EffIndicator<TVar, TContext>> _indicators = new List<EffIndicator<TVar, TContext>>();

        /// <summary>
        /// Мат. функция эффективности
        /// </summary>
        private readonly Func<IEnumerable<double>, double> _func;

        /// <summary>
        /// Конструктор функции эффективности
        /// </summary>
        /// <param name="func">мат. функция эффективности</param>
        public EffFunc(Func<IEnumerable<double>, double> func)
        {
            if (func == null) throw new ArgumentNullException(nameof(func));
            _func = func;
        }

        /// <summary>
        /// Вычислить значение эффективности
        /// </summary>
        /// <param name="var">вариант</param>
        /// <param name="context">контекст</param>
        /// <returns>значение эффективности</returns>
        public double Calc(TVar var, TContext context) => _func(_indicators.Select(x => x.Get(var, context)));

        /// <summary>
        /// Добавить индикатор
        /// </summary>
        /// <param name="indicator">индикатор</param>
        public void AddIndicator(EffIndicator<TVar, TContext> indicator)
        {
            if (indicator == null) throw new ArgumentNullException(nameof(indicator));
            _indicators.Add(indicator);
        }

        /// <summary>
        /// Удалить индикатор
        /// </summary>
        /// <param name="indicator">индикатор</param>
        /// <returns>флаг - удалено</returns>
        public bool RemoveIndicator(EffIndicator<TVar, TContext> indicator)
        {
            if (indicator == null) throw new ArgumentNullException(nameof(indicator));
            return _indicators.Remove(indicator);
        }
    }
}
