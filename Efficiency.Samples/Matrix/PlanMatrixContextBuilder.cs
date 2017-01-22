using Efficiency.Samples.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Efficiency.Samples.Matrix
{
    public class PlanMatrixContextBuilder
    {
        private readonly PlanDb _db;

        private List<EmployeePlanStat> _stat;

        private List<Employee> _choosed;

        private long? _departmentId;

        private DepartmentJob _departmentJob;

        public PlanMatrixContextBuilder(PlanDb db)
        {
            if (_db == null) throw new ArgumentNullException(nameof(db));
            _db = db;
        }

        public PlanMatrixContextBuilder SetDepartment(long departmentId)
        {
            _departmentId = departmentId;
            return this;
        }

        internal PlanMatrixContextBuilder SetDepartmentJob(DepartmentJob departmentJob)
        {
            _departmentJob = departmentJob;
            return this;
        }

        public PlanMatrixContextBuilder SetChoosed(List<Employee> choosed)
        {
            _choosed = choosed;
            return this;
        }

        public PlanMatrixContextBuilder LoadStat()
        {
            if (_departmentId == null) throw new NullReferenceException(nameof(_departmentId));

            _stat = _db.Database.SqlQuery<EmployeePlanStat>("exec planguard.p_Get_EmployeePlanStat @departmentId"
                , new SqlParameter("departmentId", _departmentId))
                .ToList();

            return this;
        }

        public PlanMatrixContext Build()
        {
            if (_departmentId == null) throw new NullReferenceException(nameof(_departmentId));


            var result = new PlanMatrixContext();
            result.DepartmentId = _departmentId.Value;
            result.Stat = _stat ?? new List<EmployeePlanStat>();
            result.Choosed = _choosed ?? new List<Employee>();

            return result;
        }
    }
}
