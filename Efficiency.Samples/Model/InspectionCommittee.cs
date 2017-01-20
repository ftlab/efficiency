namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("resultguard.InspectionCommittee")]
    public partial class InspectionCommittee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InspectionCommittee()
        {
            FlightInspectionJournal = new HashSet<FlightInspectionJournal>();
            InspectionCommitteeMembers = new HashSet<InspectionCommitteeMembers>();
        }

        public int ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CommitteeTypeID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightInspectionJournal> FlightInspectionJournal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InspectionCommitteeMembers> InspectionCommitteeMembers { get; set; }
    }
}
