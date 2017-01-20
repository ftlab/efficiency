using System.Collections.Generic;
using Efficiency.Matrix;
using Efficiency.Samples.Model;

namespace Efficiency.Samples.Matrix
{
    public class FtPlanMatrix : EffMatrix<Employee, FtPlanContext>
    {
        public FtPlanMatrix(EffFunc<Employee, FtPlanContext> func, IEnumerable<Employee> variants) : base(func, variants)
        {
        }
    }
}
