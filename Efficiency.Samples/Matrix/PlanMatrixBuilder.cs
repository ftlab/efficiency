using Efficiency.Matrix;
using Efficiency.Samples.Model;
using System;
using System.Linq;

namespace Efficiency.Samples.Matrix
{
    public class PlanMatrixBuilder : EffMatrixBuilder<Employee, PlanContext>
    {
        public PlanMatrixBuilder UseWasInSectorInLast(double weight)
        {
            AddIndicator((e, c) => weight * WasInSectorInLast(e, c));
            return this;
        }

        public PlanMatrixBuilder UseHasTutor(double weight)
        {
            AddIndicator((e, c) => weight * HasTutor(e, c));
            return this;
        }

        public PlanMatrixBuilder UseHasRestrictionBySex(double weight)
        {
            AddIndicator((e, c) => weight * HasRestrictionBySex(e, c));
            return this;
        }

        public PlanMatrixBuilder UseHasUncompatible(double weight)
        {
            AddIndicator((e, c) => weight * HasUncompatible(e, c));
            return this;
        }

        public PlanMatrixBuilder UseInJobChain(double weight)
        {
            AddIndicator((e, c) => weight * InJobChain(e, c));
            return this;
        }

        public PlanMatrixBuilder UseExpierence(double weight)
        {
            AddIndicator((e, c) => weight * Expierence(e, c));
            return this;
        }

        private static double WasInSectorInLast(Employee e, PlanContext context)
        {
            var last = context.GetLast(e);
            if (last == null || context.Sector == null) return 1;
            return last.SectorId == context.Sector.Id ? 0 : 1;
        }

        private static double HasTutor(Employee e, PlanContext context)
        {
            return context.Tutors.Any(x =>
            context.Choosed.Any(y => y.Id == x.Key
            && x.Value.Contains(e.Id)))
            ? 1 : 0;
        }

        private static double HasRestrictionBySex(Employee e, PlanContext context)
        {
            if (e.UseDepartmentJobSexRestrictions == false) return 1;
            if (string.IsNullOrEmpty(context.DepartmentJob.RestrictedSex)) return 1;
            return context.DepartmentJob.RestrictedSex == e.Sex
                ? 1 : 0;
        }

        private static double HasUncompatible(Employee e, PlanContext context)
        {
            return context.Choosed.Any(x =>
            context.Uncompatibles.Any(y =>
            y.Key == x.Id && y.Value == e.Id
            || y.Key == e.Id && y.Value == x.Id))
            ? 0 : 1;
        }

        private static double InJobChain(Employee e, PlanContext context)
        {
            var chain = context.GetJobChain();
            if (chain == null)
                return 1;

            var stat = context.GetLast(e);
            if (stat == null)
                return 1;

            var chainNode = chain.Find(context.DepartmentJob.Id);
            if (chainNode == null) throw new NullReferenceException(nameof(chainNode));
            if (chainNode.Previous != null && chainNode.Previous.Value == stat.DepartmentJobId)
                return 1;
            return 0;
        }

        private static double Expierence(Employee e, PlanContext context)
        {
            double? expierence = e.EmployeeDepartmentJob
                .FirstOrDefault(x => x.DepartmentJobId == context.DepartmentJob.Id)
                ?.Experience ?? e.Experience;

            if (expierence == null)
                expierence = 0;

            return Math.Min(Math.Max(expierence.Value, 0), 100) / 100;

        }
    }
}
