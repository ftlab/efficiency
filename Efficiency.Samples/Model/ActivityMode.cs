namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.ActivityMode")]
    public partial class ActivityMode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ActivityMode()
        {
            RegimeActivity = new HashSet<RegimeActivity>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Сomment { get; set; }

        public short? StartEventRawTypeId { get; set; }

        public short? StopEventRawTypeId { get; set; }

        public bool? isDeleted { get; set; }

        public virtual EventRawType EventRawType { get; set; }

        public virtual EventRawType EventRawType1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegimeActivity> RegimeActivity { get; set; }
    }
}
