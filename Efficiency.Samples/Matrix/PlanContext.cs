using Efficiency.Samples.Model;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Efficiency.Samples.Matrix
{
    public class PlanContext
    {
        public readonly List<EmployeePlanStat> Stat = new List<EmployeePlanStat>();

        public readonly List<Employee> Choosed = new List<Employee>();

        public readonly Dictionary<long, List<long>> Tutors = new Dictionary<long, List<long>>();

        public readonly List<KeyValuePair<long, long>> Uncompatibles = new List<KeyValuePair<long, long>>();

        public readonly List<LinkedList<long>> JobChains = new List<LinkedList<long>>();

        public long DepartmentId;

        public Sector Sector;

        public DepartmentJob DepartmentJob;

        public EmployeePlanStat GetLast(Employee e)
        {
            return GetStat(e)
                .FirstOrDefault();
        }

        public LinkedList<long> GetJobChain()
        {
            return JobChains.FirstOrDefault(x => x.Contains(DepartmentJob.Id));
        }

        internal IEnumerable<EmployeePlanStat> GetStat(Employee e)
        {
            return Stat.Where(x => x.EmployeeId == e.Id)
                .OrderByDescending(x => x.BeginDateTime);
        }
    }
}
