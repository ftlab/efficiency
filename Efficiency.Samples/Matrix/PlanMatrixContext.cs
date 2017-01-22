using Efficiency.Samples.Model;
using System.Collections.Generic;
using System;
using System.Linq;
using Efficiency.Matrix;

namespace Efficiency.Samples.Matrix
{
    public class PlanMatrixContext : IEffMatrixContext<Employee>
    {
        public List<EmployeePlanStat> Stat = new List<EmployeePlanStat>();

        public List<Employee> Choosed = new List<Employee>();

        public Dictionary<long, List<long>> Tutors = new Dictionary<long, List<long>>();

        public List<KeyValuePair<long, long>> Uncompatibles = new List<KeyValuePair<long, long>>();

        public List<LinkedList<long>> JobChains = new List<LinkedList<long>>();

        public List<Employee> _resources = new List<Employee>();

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

        public IEnumerable<Employee> Get()
        {
            return _resources;
        }
    }
}
