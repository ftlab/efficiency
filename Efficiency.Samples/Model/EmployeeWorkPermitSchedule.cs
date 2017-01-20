namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.EmployeeWorkPermitSchedule")]
    public partial class EmployeeWorkPermitSchedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeWorkPermitSchedule()
        {
            BorderProtectionScheduleDetail = new HashSet<BorderProtectionScheduleDetail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long EmployeeId { get; set; }

        public long WorkPermitTypeId { get; set; }

        public DateTime BeginDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        [StringLength(1000)]
        public string Reason { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleDetail> BorderProtectionScheduleDetail { get; set; }

        public virtual WorkPermitType WorkPermitType { get; set; }
    }
}
