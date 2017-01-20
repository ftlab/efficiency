namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("flight.Flight")]
    public partial class Flight1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flight1()
        {
            FlightInspectionJournal = new HashSet<FlightInspectionJournal>();
            FlightInspectionJournal1 = new HashSet<FlightInspectionJournal>();
            Passenger1 = new HashSet<Passenger1>();
        }

        public long ID { get; set; }

        public int AirlineID { get; set; }

        public long DirectionID { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateDeparture { get; set; }

        [Required]
        [StringLength(7)]
        public string FlightNumber { get; set; }

        [StringLength(128)]
        public string Airport { get; set; }

        public DateTime? scheduleTimeArr { get; set; }

        [StringLength(10)]
        public string acType { get; set; }

        public DateTime? actualTimeArr { get; set; }

        public DateTime? actualTimeDep { get; set; }

        public DateTime? estimateTimeArr { get; set; }

        public DateTime? scheduleTimeDep { get; set; }

        public DateTime? estimateTimeDep { get; set; }

        public int? PAX_ECON { get; set; }

        public int? PAX_BUS { get; set; }

        public int? PAX_FIRST { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? PAX_ALL { get; set; }

        [StringLength(20)]
        public string flId { get; set; }

        [StringLength(50)]
        public string AgentType { get; set; }

        public byte StatusID { get; set; }

        [StringLength(20)]
        public string EstimateParkingArea { get; set; }

        [StringLength(20)]
        public string ActualParkingArea { get; set; }

        [StringLength(255)]
        public string ReasonDelay { get; set; }

        [StringLength(255)]
        public string Sections { get; set; }

        [StringLength(10)]
        public string RegistrationCode { get; set; }

        public TimeSpan? TravelTime { get; set; }

        public int? PassengerCount { get; set; }

        public int? CrewCount { get; set; }

        public virtual Airline Airline { get; set; }

        public virtual Direction Direction { get; set; }

        public virtual FlightStatus FlightStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightInspectionJournal> FlightInspectionJournal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightInspectionJournal> FlightInspectionJournal1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Passenger1> Passenger1 { get; set; }
    }
}
