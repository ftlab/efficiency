namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            agr_ArmSession = new HashSet<agr_ArmSession>();
            agr_ArmSessionHistory = new HashSet<agr_ArmSessionHistory>();
            EmployeeKaskadUser = new HashSet<EmployeeKaskadUser>();
            BorderProtectionScheduleChronometry = new HashSet<BorderProtectionScheduleChronometry>();
            BorderProtectionScheduleDetail = new HashSet<BorderProtectionScheduleDetail>();
            BorderProtectionScheduleReinforcement = new HashSet<BorderProtectionScheduleReinforcement>();
            ControlledPerson = new HashSet<ControlledPerson>();
            ControlledPersonOfficerHistory = new HashSet<ControlledPersonOfficerHistory>();
            ControlledPersonOfficerHistory1 = new HashSet<ControlledPersonOfficerHistory>();
            CustomEventProperties = new HashSet<CustomEventProperties>();
            Employee_ReportGroup = new HashSet<Employee_ReportGroup>();
            Employee__Statistic_Control = new HashSet<Employee__Statistic_Control>();
            EmployeeCard = new HashSet<EmployeeCard>();
            EmployeeCompatibilityList = new HashSet<EmployeeCompatibilityList>();
            EmployeeCompatibilityList1 = new HashSet<EmployeeCompatibilityList>();
            EmployeeDepartmentGroup = new HashSet<EmployeeDepartmentGroup>();
            EmployeeDepartmentJob = new HashSet<EmployeeDepartmentJob>();
            EmployeeOrganizationalStructure = new HashSet<EmployeeOrganizationalStructure>();
            EmployeeOverProcessing = new HashSet<EmployeeOverProcessing>();
            EmployeeWorkPermitSchedule = new HashSet<EmployeeWorkPermitSchedule>();
            EventLog = new HashSet<EventLog>();
            EventPhotoAttachments = new HashSet<EventPhotoAttachments>();
            EventLogRaw = new HashSet<EventLogRaw>();
            EventPTKLogAttachment = new HashSet<EventPTKLogAttachment>();
            EventVideoAttachment = new HashSet<EventVideoAttachment>();
            OrganizationalStructureChief = new HashSet<OrganizationalStructureChief>();
            Dashboard_Configuration = new HashSet<Dashboard_Configuration>();
            EventLog1 = new HashSet<EventLog>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Required]
        [StringLength(300)]
        public string FullName { get; set; }

        public long? MilitaryRankId { get; set; }

        [StringLength(100)]
        public string PersonalNumber { get; set; }

        [StringLength(100)]
        public string ChestSign { get; set; }

        [StringLength(100)]
        public string DateStamp { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDate { get; set; }

        public byte[] Photo { get; set; }

        public bool? IsDeleted { get; set; }

        public bool? IsWorkLimitationApplyed { get; set; }

        public TimeSpan? PermissibleWorkTimeFrom { get; set; }

        public TimeSpan? PermissibleWorkTimeTo { get; set; }

        public bool? NoComputerWorkAllowed { get; set; }

        public int? NumberByKPD { get; set; }

        public byte[] DataStampImage { get; set; }

        public TimeSpan? LunchPlanedTimeDay { get; set; }

        public TimeSpan? LunchPlanedTimeNight { get; set; }

        public bool? IsSystem { get; set; }

        public byte? Experience { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        public bool UseDepartmentJobSexRestrictions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<agr_ArmSession> agr_ArmSession { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<agr_ArmSessionHistory> agr_ArmSessionHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeKaskadUser> EmployeeKaskadUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleChronometry> BorderProtectionScheduleChronometry { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleDetail> BorderProtectionScheduleDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleReinforcement> BorderProtectionScheduleReinforcement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ControlledPerson> ControlledPerson { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ControlledPersonOfficerHistory> ControlledPersonOfficerHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ControlledPersonOfficerHistory> ControlledPersonOfficerHistory1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomEventProperties> CustomEventProperties { get; set; }

        public virtual MilitaryRank MilitaryRank { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_ReportGroup> Employee_ReportGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee__Statistic_Control> Employee__Statistic_Control { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeCard> EmployeeCard { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeCompatibilityList> EmployeeCompatibilityList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeCompatibilityList> EmployeeCompatibilityList1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeDepartmentGroup> EmployeeDepartmentGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeDepartmentJob> EmployeeDepartmentJob { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeOrganizationalStructure> EmployeeOrganizationalStructure { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeOverProcessing> EmployeeOverProcessing { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeWorkPermitSchedule> EmployeeWorkPermitSchedule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventLog> EventLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventPhotoAttachments> EventPhotoAttachments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventLogRaw> EventLogRaw { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventPTKLogAttachment> EventPTKLogAttachment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventVideoAttachment> EventVideoAttachment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationalStructureChief> OrganizationalStructureChief { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dashboard_Configuration> Dashboard_Configuration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventLog> EventLog1 { get; set; }
    }
}
