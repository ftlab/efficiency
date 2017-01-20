namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanPerson.Passenger")]
    public partial class Passenger1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Passenger1()
        {
            PassengerFile_Passenger = new HashSet<PassengerFile_Passenger>();
            Passenger_FIO_RUS = new HashSet<Passenger_FIO_RUS>();
        }

        public long ID { get; set; }

        public long FlightID { get; set; }

        [StringLength(128)]
        public string DocumentType { get; set; }

        [StringLength(3)]
        public string CountryIssue { get; set; }

        [StringLength(16)]
        public string DocumentNumber { get; set; }

        [StringLength(3)]
        public string NationalIssue { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateBirth { get; set; }

        [Column(TypeName = "date")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateBirthInner { get; set; }

        [StringLength(3)]
        public string Sex { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateExpiry { get; set; }

        [Required]
        [StringLength(256)]
        public string FIOPassenger { get; set; }

        public bool IsDeleted { get; set; }

        public bool? isEGIS { get; set; }

        public bool? isSitatex { get; set; }

        [StringLength(20)]
        public string Locator { get; set; }

        public virtual Flight1 Flight1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PassengerFile_Passenger> PassengerFile_Passenger { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Passenger_FIO_RUS> Passenger_FIO_RUS { get; set; }
    }
}
