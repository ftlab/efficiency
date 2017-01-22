using Efficiency.Samples.Model;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Efficiency.Samples.Matrix
{
    public class FtPlanContext
    {
        public readonly List<EmployeePlanStat> Stat = new List<EmployeePlanStat>();

        public readonly List<Employee> Choosed = new List<Employee>();

        public Sector Sector;

        public DepartmentJob DepartmentJob;

        public EmployeePlanStat GetLast(Employee e)
        {
            if (e == null) throw new ArgumentNullException(nameof(e));
            return Stat.Where(x => x.EmployeeId == e.Id)
                .OrderByDescending(x => x.BeginDateTime)
                .FirstOrDefault();
        }
    }
}
