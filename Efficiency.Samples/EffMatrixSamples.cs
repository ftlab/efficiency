using Efficiency.Samples.Matrix;
using Efficiency.Samples.Model;
using System;

namespace Efficiency.Samples
{
    public class EffMatrixSamples
    {
        public void Builder()
        {
            var context = new PlanContext();
            var matrix = new PlanMatrixBuilder()
                 .UseWasInSectorInLast(5)
                 .UseSum()
                 .Build();

            var employee = matrix.GetEffectiveVar(context);
        }
    }
}
