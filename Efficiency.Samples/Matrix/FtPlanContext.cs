using Efficiency.Samples.Model;
using System.Collections.Generic;

namespace Efficiency.Samples.Matrix
{
    public class FtPlanContext
    {
        public readonly List<Employee> _choosed = new List<Employee>();

        public Sector Sector;

        public DepartmentJob DepartmentJob;
    }
}
