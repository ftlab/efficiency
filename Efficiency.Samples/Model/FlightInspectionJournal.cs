namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("flight.FlightInspectionJournal")]
    public partial class FlightInspectionJournal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FlightInspectionJournal()
        {
            FlightInspectionJournal1 = new HashSet<FlightInspectionJournal>();
        }

        public long ID { get; set; }

        public long? ParentID { get; set; }

        public long FlightID { get; set; }

        public byte FlightInspectionJournalStatusID { get; set; }

        public DateTime? BeginTime { get; set; }

        public DateTime? EndTime { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FlightModeId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FlightTypeId { get; set; }

        public long? TransitFlightID { get; set; }

        public int? InspectionCommitteeID { get; set; }

        public byte? CrewCount { get; set; }

        public short? Passengers_Count { get; set; }

        public short? Passengers_Ill_Count { get; set; }

        public short? Passengers_Dip_Count { get; set; }

        public short? Passengers_Feld_Count { get; set; }

        public short? Passengers_Dep_Count { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CarrierDecisionID { get; set; }

        public byte ExportStatusID { get; set; }

        public bool isDeleted { get; set; }

        public virtual FlightInspectionJournalStatus FlightInspectionJournalStatus { get; set; }

        public virtual Flight1 Flight1 { get; set; }

        public virtual Flight1 Flight11 { get; set; }

        public virtual InspectionCommittee InspectionCommittee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightInspectionJournal> FlightInspectionJournal1 { get; set; }

        public virtual FlightInspectionJournal FlightInspectionJournal2 { get; set; }
    }
}
