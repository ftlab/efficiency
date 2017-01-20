namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stat.SC_JobHistory")]
    public partial class SC_JobHistory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SC_JobHistory()
        {
            SC_JobError = new HashSet<SC_JobError>();
        }

        public long ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public byte Status { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public int? ib_EventCount { get; set; }

        public int? cmior_EventCount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SC_JobError> SC_JobError { get; set; }
    }
}
