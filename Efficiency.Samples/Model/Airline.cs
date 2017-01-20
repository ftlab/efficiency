namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.Airline")]
    public partial class Airline
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Airline()
        {
            FlightTransitionLinks = new HashSet<FlightTransitionLinks>();
            FlightTransitionLinks1 = new HashSet<FlightTransitionLinks>();
            AirlineCode = new HashSet<AirlineCode>();
            Flight1 = new HashSet<Flight1>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public long? TransportCompanyID { get; set; }

        [StringLength(50)]
        public string NameIATA { get; set; }

        [StringLength(50)]
        public string NameRUS { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [StringLength(50)]
        public string ContactEmail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightTransitionLinks> FlightTransitionLinks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightTransitionLinks> FlightTransitionLinks1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AirlineCode> AirlineCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flight1> Flight1 { get; set; }
    }
}
