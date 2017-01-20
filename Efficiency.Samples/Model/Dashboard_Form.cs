namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("param.Dashboard_Form")]
    public partial class Dashboard_Form
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dashboard_Form()
        {
            Dashboard_Control = new HashSet<Dashboard_Control>();
            Dashboard_Display = new HashSet<Dashboard_Display>();
        }

        public int ID { get; set; }

        public int Dashboard_Configuration_ID { get; set; }

        public DateTime ChangeDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        [Column(TypeName = "xml")]
        [Required]
        public string Content { get; set; }

        [Column(TypeName = "xml")]
        public string Subscribe_Message { get; set; }

        public virtual Dashboard_Configuration Dashboard_Configuration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dashboard_Control> Dashboard_Control { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dashboard_Display> Dashboard_Display { get; set; }
    }
}
