namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stat.Employee_ReportGroup")]
    public partial class Employee_ReportGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee_ReportGroup()
        {
            Employee__Statistic_Control = new HashSet<Employee__Statistic_Control>();
            Employee_ReportGroup1 = new HashSet<Employee_ReportGroup>();
        }

        public int ID { get; set; }

        public long EmployeeID { get; set; }

        public int? ParentID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee__Statistic_Control> Employee__Statistic_Control { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_ReportGroup> Employee_ReportGroup1 { get; set; }

        public virtual Employee_ReportGroup Employee_ReportGroup2 { get; set; }
    }
}
