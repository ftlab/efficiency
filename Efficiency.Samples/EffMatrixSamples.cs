using Efficiency.Samples.Matrix;
using Efficiency.Samples.Model;

namespace Efficiency.Samples
{
    public class EffMatrixSamples
    {
        public void Builder()
        {
            var context = new FtPlanContext();

            var matrix = new FtPlanBuilder()
                 .UseSum()
                 .AddIndicator(P1)
                 .Build();

            var employee = matrix.GetEffectiveVar(context);
        }

        public static double P1(Employee e, FtPlanContext context)
        {
            return 0;
        }
    }
}
