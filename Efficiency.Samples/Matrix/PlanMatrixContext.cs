using Efficiency.Samples.Model;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Data.Entity;
using System.Data.SqlClient;

namespace Efficiency.Samples.Matrix
{
    public class PlanMatrixContext
    {
        private long _headerId;

        private BorderProtectionScheduleHeader _header;

        private PlanDb _db;

        private List<EmployeePlanStat> _stat;

        private List<LinkedList<long>> _jobChains;

        private Dictionary<long, List<long>> _tutors;

        private List<KeyValuePair<long, long>> _uncompatibles;

        public PlanMatrixContext(PlanDb db, long headerId)
        {
            if (db == null) throw new ArgumentNullException(nameof(db));
            _db = db;
            _headerId = headerId;
        }

        public Sector CurrentSector { get; set; }

        public DepartmentJob CurrentJob { get; set; }

        public List<Employee> Choosed { get; set; }

        public PlanDb Db => _db;

        public BorderProtectionScheduleHeader Header
        {
            get
            {
                if (_header != null) return _header;

                var query = from schedule in Db.BorderProtectionScheduleHeader
                            where schedule.Id == _headerId
                            select schedule;

                Db.DepartmentJob.Load();
                Db.DepartmentGroup.Load();
                Db.OrganizationalStructure.Load();
                Db.Sector.Load();

                query = query.Include(x => x.DepartmentWorkSchedule)
                            .Include(x => x.BorderProtectionScheduleSector.Select(y => y.Sector.Direction))
                            .Include(x => x.BorderProtectionScheduleTargets)
                            .Include(x => x.BorderProtectionScheduleDetail)
                            .Include(x => x.BorderProtectionScheduleDetail.Select(y => y.LocationRoute))
                            .Include(x => x.BorderProtectionScheduleDetail.Select(y => y.Employee.MilitaryRank))
                            .Include(x => x.BorderProtectionScheduleDetail.Select(y => y.Employee.EmployeeOrganizationalStructure))
                            .Include(x => x.BorderProtectionScheduleDetail.Select(y => y.Employee.EmployeeDepartmentGroup))
                            .Include(x => x.BorderProtectionScheduleDetail.Select(y => y.Employee.EmployeeDepartmentJob))
                            .Include(x => x.BorderProtectionScheduleReserve)
                            .Include(x => x.OrganizationalStructure.OrganizationalStructureChief)
                            .Include(x => x.OrganizationalStructure.OrganizationalStructureChief.Select(y => y.Employee));

                _header = query.FirstOrDefault();
                if (_header == null) throw new NullReferenceException(nameof(_header));
                return _header;
            }
        }

        public List<EmployeePlanStat> Stat
        {
            get
            {
                if (_stat != null) return _stat;

                _stat = Db.Database.SqlQuery<EmployeePlanStat>("exec planguard.p_Get_EmployeePlanStat @departmentId"
                , new SqlParameter("departmentId", Header.DepartmentId))
                .ToList();

                if (_stat == null) throw new NullReferenceException(nameof(_stat));
                return _stat;
            }
        }

        public List<LinkedList<long>> JobChains
        {
            get
            {
                if (_jobChains != null) return _jobChains;
                throw new NotImplementedException();
            }
        }

        public Dictionary<long, List<long>> Tutors
        {
            get
            {
                if (_tutors != null) return _tutors;

                _tutors = Db.EmployeeCompatibilityList
                .Where(x => x.CompatibilityTypeId == EmployeeCompatibilityType.Tutorship)
                .GroupBy(x => x.EmployeeId)
                .ToDictionary(x => x.Key, y => y.Select(x => x.ToEmployeeId).ToList());

                return _tutors;
            }
        }

        public List<KeyValuePair<long, long>> Uncompatibles
        {
            get
            {
                if (_uncompatibles != null) return _uncompatibles;

                _uncompatibles = Db.EmployeeCompatibilityList
                .Where(x => x.CompatibilityTypeId == EmployeeCompatibilityType.Incompatibility)
                .Select(x => new KeyValuePair<long, long>(x.EmployeeId, x.ToEmployeeId))
                .ToList();

                return _uncompatibles;
            }
        }


        public EmployeePlanStat GetLast(Employee e)
        {
            return GetStat(e)
                .FirstOrDefault();
        }

        public LinkedList<long> GetCurrentChain()
        {
            return JobChains.FirstOrDefault(x => x.Contains(CurrentJob.Id));
        }

        internal IEnumerable<EmployeePlanStat> GetStat(Employee e)
        {
            return Stat.Where(x => x.EmployeeId == e.Id)
                .OrderByDescending(x => x.BeginDateTime);
        }

    }
}
