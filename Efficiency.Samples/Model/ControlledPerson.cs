namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("resultguard.ControlledPerson")]
    public partial class ControlledPerson
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ControlledPerson()
        {
            ControlledPersonOfficerHistory = new HashSet<ControlledPersonOfficerHistory>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [StringLength(100)]
        public string FIO { get; set; }

        public long? CitizenshipID { get; set; }

        public int? SexID { get; set; }

        [StringLength(200)]
        public string DUL { get; set; }

        [StringLength(50)]
        public string FlightNumberArrival { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FlightDateTimeArrival { get; set; }

        public long? AirlineFlightArrivalID { get; set; }

        public long? CountryFlightArrivalID { get; set; }

        public long? CityFlightArrivalID { get; set; }

        [StringLength(100)]
        public string ReasonNotPass { get; set; }

        public long? PersonLocationID { get; set; }

        [StringLength(50)]
        public string NumberFlightSend { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateTimerFlightSend { get; set; }

        public long? AirlineFlightSendID { get; set; }

        public long? CountryFlightSendID { get; set; }

        public long? CityFlightSendID { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        public long? PersonStatusID { get; set; }

        public long? ResponsibleOfficerID { get; set; }

        public long? BorderCrossingID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? MinOperationTime { get; set; }

        public virtual ControlledPersonLocation ControlledPersonLocation { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ControlledPersonOfficerHistory> ControlledPersonOfficerHistory { get; set; }
    }
}
