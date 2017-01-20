namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanPerson.I_EGISOTB_Flight")]
    public partial class I_EGISOTB_Flight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public I_EGISOTB_Flight()
        {
            I_EGISOTB_Passenger = new HashSet<I_EGISOTB_Passenger>();
        }

        public long ID { get; set; }

        public byte DirectionID { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateDeparture { get; set; }

        [Required]
        [StringLength(10)]
        public string FlightNumber { get; set; }

        [StringLength(100)]
        public string AirportDeparture { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<I_EGISOTB_Passenger> I_EGISOTB_Passenger { get; set; }
    }
}
