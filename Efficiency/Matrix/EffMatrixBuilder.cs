using System;
using System.Collections.Generic;
using System.Linq;

namespace Efficiency.Matrix
{
    /// <summary>
    /// Построитель матрицы эффективности
    /// </summary>
    /// <typeparam name="TVar">тип варианта</typeparam>
    /// <typeparam name="TContext">тип контекста</typeparam>
    public class EffMatrixBuilder<TVar, TContext>
        where TContext : IEffMatrixContext<TVar>
    {
        /// <summary>
        /// Функция эффективности
        /// </summary>
        private Func<IEnumerable<double>, double> _func;

        /// <summary>
        /// Список индикаторов эффективности
        /// </summary>
        private List<Func<TVar, TContext, double>> _indicators;

        /// <summary>
        /// Использовать функцию
        /// </summary>
        /// <param name="func">функция эффективности</param>
        /// <returns>построитель</returns>
        public EffMatrixBuilder<TVar, TContext> UseFunc(Func<IEnumerable<double>, double> func)
        {
            if (func == null) throw new ArgumentNullException(nameof(func));
            _func = func;
            return this;
        }

        /// <summary>
        /// Использовать сумму
        /// </summary>
        /// <returns>построитель</returns>
        public EffMatrixBuilder<TVar, TContext> UseSum() => UseFunc(x => x.Sum());

        /// <summary>
        /// Использовать максимум
        /// </summary>
        /// <returns>построитель</returns>
        public EffMatrixBuilder<TVar, TContext> UseMax() => UseFunc(x => x.Max());

        /// <summary>
        /// Использовать минимум
        /// </summary>
        /// <returns>построитель</returns>
        public EffMatrixBuilder<TVar, TContext> UseMin() => UseFunc(x => x.Min());

        /// <summary>
        /// Использовать среднее
        /// </summary>
        /// <returns>построитель</returns>
        public EffMatrixBuilder<TVar, TContext> UseAverage() => UseFunc(x => x.Average());

        /// <summary>
        /// Использовать индикатор
        /// </summary>
        /// <param name="func">фукнция индикатора</param>
        /// <returns>построитель</returns>
        public EffMatrixBuilder<TVar, TContext> AddIndicator(Func<TVar, TContext, double> func)
        {
            if (func == null) throw new ArgumentNullException(nameof(func));
            if (_indicators == null) _indicators = new List<Func<TVar, TContext, double>>();
            _indicators.Add(func);
            return this;
        }


        /// <summary>
        /// Построить матрицу эффективности
        /// </summary>
        /// <returns>матрица эффективности</returns>
        public virtual EffMatrix<TVar, TContext> Build()
        {
            var func = new EffFunc<TVar, TContext>(_func);
            _indicators.ForEach(x => func.AddIndicator(new EffIndicator<TVar, TContext>(x)));
            var matrix = new EffMatrix<TVar, TContext>(func);
            return matrix;
        }
    }
}
