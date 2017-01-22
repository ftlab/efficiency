namespace Efficiency.Samples.Matrix
{
    using Model;
    using System.Data.Entity;

    public partial class PlanDb : DbContext
    {
        static PlanDb()
        {
            Database.SetInitializer<PlanDb>(null);
        }

        public virtual DbSet<BorderProtectionPlan> BorderProtectionPlan { get; set; }
        public virtual DbSet<BorderProtectionScheduleChronometry> BorderProtectionScheduleChronometry { get; set; }
        public virtual DbSet<BorderProtectionScheduleDetail> BorderProtectionScheduleDetail { get; set; }
        public virtual DbSet<BorderProtectionScheduleHeader> BorderProtectionScheduleHeader { get; set; }
        public virtual DbSet<BorderProtectionScheduleReserve> BorderProtectionScheduleReserve { get; set; }
        public virtual DbSet<BorderProtectionScheduleSector> BorderProtectionScheduleSector { get; set; }
        public virtual DbSet<BorderProtectionScheduleTargets> BorderProtectionScheduleTargets { get; set; }
        public virtual DbSet<ChiefType> ChiefType { get; set; }
        public virtual DbSet<DepartmentGroup> DepartmentGroup { get; set; }
        public virtual DbSet<DepartmentJob> DepartmentJob { get; set; }
        public virtual DbSet<DepartmentStaff> DepartmentStaff { get; set; }
        public virtual DbSet<DepartmentTargets> DepartmentTargets { get; set; }
        public virtual DbSet<DepartmentWorkSchedule> DepartmentWorkSchedule { get; set; }
        public virtual DbSet<Direction> Direction { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeDepartmentGroup> EmployeeDepartmentGroup { get; set; }
        public virtual DbSet<EmployeeDepartmentJob> EmployeeDepartmentJob { get; set; }
        public virtual DbSet<EmployeeOrganizationalStructure> EmployeeOrganizationalStructure { get; set; }
        public virtual DbSet<EmployeeOverProcessing> EmployeeOverProcessing { get; set; }
        public virtual DbSet<EmployeeWorkPermitSchedule> EmployeeWorkPermitSchedule { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<MilitaryRank> MilitaryRank { get; set; }
        public virtual DbSet<OrganizationalStructure> OrganizationalStructure { get; set; }
        public virtual DbSet<OrganizationalStructureChief> OrganizationalStructureChief { get; set; }
        public virtual DbSet<OrganizationalStructureType> OrganizationalStructureType { get; set; }
        public virtual DbSet<ReportTemplate> ReportTemplate { get; set; }
        public virtual DbSet<ReportType> ReportType { get; set; }
        public virtual DbSet<Sector> Sector { get; set; }
        public virtual DbSet<WorkPermitType> WorkPermitType { get; set; }
        public virtual DbSet<WorkScheduleType> WorkScheduleType { get; set; }
        public virtual DbSet<WorkingCalendar> WorkingCalendar { get; set; }
        public virtual DbSet<EmployeeCompatibilityList> EmployeeCompatibilityList { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
