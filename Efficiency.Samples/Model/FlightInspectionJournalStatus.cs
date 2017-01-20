namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.FlightInspectionJournalStatus")]
    public partial class FlightInspectionJournalStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FlightInspectionJournalStatus()
        {
            FlightInspectionJournal = new HashSet<FlightInspectionJournal>();
        }

        public byte ID { get; set; }

        [Required]
        [StringLength(15)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightInspectionJournal> FlightInspectionJournal { get; set; }
    }
}
