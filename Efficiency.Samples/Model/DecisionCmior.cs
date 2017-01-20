namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("controlresult.DecisionCmior")]
    public partial class DecisionCmior
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DecisionCmior()
        {
            ControlRequest = new HashSet<ControlRequest>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long DecisionID { get; set; }

        [StringLength(100)]
        public string DecisionName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ControlRequest> ControlRequest { get; set; }
    }
}
