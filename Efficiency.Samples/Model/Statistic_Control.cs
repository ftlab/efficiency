namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("param.Statistic_Control")]
    public partial class Statistic_Control
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Statistic_Control()
        {
            Dashboard_Control = new HashSet<Dashboard_Control>();
            Employee__Statistic_Control = new HashSet<Employee__Statistic_Control>();
        }

        public int ID { get; set; }

        public int Group_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string ControlType { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public DateTime ChangeDate { get; set; }

        [Required]
        public string Description { get; set; }

        [Column(TypeName = "xml")]
        [Required]
        public string Content { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dashboard_Control> Dashboard_Control { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee__Statistic_Control> Employee__Statistic_Control { get; set; }

        public virtual Statistic_Control_Group Statistic_Control_Group { get; set; }
    }
}
