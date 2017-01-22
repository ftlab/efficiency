using Efficiency.Samples.Matrix;
using Efficiency.Samples.Model;
using System;

namespace Efficiency.Samples
{
    public class EffMatrixSamples
    {
        public void Builder()
        {
            var context = new FtPlanContext();
            var matrix = new FtPlanMatrixBuilder()
                 .UseSum()
                 .AddIndicator(5, HasTutor)
                 .AddIndicator(5, WasInSectorInLast)
                 .Build();

            var employee = matrix.GetEffectiveVar(context);
        }

        public static double WasInSectorInLast(Employee e, FtPlanContext context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));
            var last = context.GetLast(e);
            if (last == null || context.Sector == null) return 1;

            return last.SectorId == context.Sector.Id ? 0 : 1;
        }
        public static double HasTutor(Employee e, FtPlanContext context) => 0;
    }
}
