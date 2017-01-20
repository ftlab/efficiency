namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("param.Statistic_Control_Group")]
    public partial class Statistic_Control_Group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Statistic_Control_Group()
        {
            Statistic_Control = new HashSet<Statistic_Control>();
            Statistic_Control_Group1 = new HashSet<Statistic_Control_Group>();
        }

        public int ID { get; set; }

        public int? Parent_Group_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Statistic_Control> Statistic_Control { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Statistic_Control_Group> Statistic_Control_Group1 { get; set; }

        public virtual Statistic_Control_Group Statistic_Control_Group2 { get; set; }
    }
}
