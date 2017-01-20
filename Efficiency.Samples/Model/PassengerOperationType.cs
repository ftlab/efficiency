namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanPerson.PassengerOperationType")]
    public partial class PassengerOperationType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PassengerOperationType()
        {
            PassengerFile_Passenger = new HashSet<PassengerFile_Passenger>();
        }

        public byte ID { get; set; }

        [Required]
        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PassengerFile_Passenger> PassengerFile_Passenger { get; set; }
    }
}
