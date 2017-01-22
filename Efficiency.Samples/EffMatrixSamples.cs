using Efficiency.Samples.Matrix;
using Efficiency.Samples.Model;
using System;
using System.Collections.Generic;

namespace Efficiency.Samples
{
    public class EffMatrixSamples
    {
        public void Builder()
        {
            var db = new PlanDb();

            long deparmentId = 1;
            DepartmentJob departmentJob = null;
            Sector sector = null;

            var choosed = new List<Employee>();
            List<Employee> resources;

            var matrix = new PlanMatrixBuilder()
                 .UseWasInSectorInLast(16)
                 .UseHasRestrictionBySex(8)
                 .UseHasUncompatible(4)
                 .UseJobChain(2)
                 .UseExpierence(1)
                 .UseSum()
                 .Build();

            var employee = matrix.GetEffectiveVar(null, new PlanMatrixContext(db, 1));
        }
    }
}
