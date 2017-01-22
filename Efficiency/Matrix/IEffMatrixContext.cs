using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efficiency.Matrix
{
    /// <summary>
    /// Контекст матирцы
    /// </summary>
    /// <typeparam name="TVar"></typeparam>
    public interface IEffMatrixContext<TVar>
    {
        /// <summary>
        /// Получить все варианты
        /// </summary>
        /// <returns></returns>
        IEnumerable<TVar> Get();
    }
}
