namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("param.Dashboard_Configuration")]
    public partial class Dashboard_Configuration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dashboard_Configuration()
        {
            ArmType_Dashboard_Configuration = new HashSet<ArmType_Dashboard_Configuration>();
            Dashboard_Form = new HashSet<Dashboard_Form>();
            Employee = new HashSet<Employee>();
        }

        public int ID { get; set; }

        public int? Dashboard_Display_Collection_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        public DateTime ChangeDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArmType_Dashboard_Configuration> ArmType_Dashboard_Configuration { get; set; }

        public virtual Dashboard_Display_Collection Dashboard_Display_Collection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dashboard_Form> Dashboard_Form { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employee { get; set; }
    }
}
