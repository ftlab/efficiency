using System;

namespace Efficiency.Matrix
{
    /// <summary>
    /// Индикатор эффективности
    /// </summary>
    /// <typeparam name="TVar">тип варианта</typeparam>
    /// <typeparam name="TContext">тип контекста</typeparam>
    public class EffIndicator<TVar, TContext>
    {
        /// <summary>
        /// Функция индикатора
        /// </summary>
        private Func<TVar, TContext, double> _func;

        /// <summary>
        /// Конструктор индикатора эффективности
        /// </summary>
        /// <param name="func">функция индикатора</param>
        public EffIndicator(Func<TVar, TContext, double> func)
        {
            if (func == null) throw new ArgumentNullException(nameof(func));
            _func = func;
        }

        /// <summary>
        /// Получить значение индикатора
        /// </summary>
        /// <param name="var">вариант</param>
        /// <param name="context">контекст</param>
        /// <returns></returns>
        public double Get(TVar var, TContext context) => _func(var, context);
    }
}
