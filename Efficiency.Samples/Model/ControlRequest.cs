namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("controlresult.ControlRequest")]
    public partial class ControlRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ControlRequest()
        {
            PostResult = new HashSet<PostResult>();
            EventLog = new HashSet<EventLog>();
            EventLogRaw = new HashSet<EventLogRaw>();
        }

        [Key]
        public long ControlID { get; set; }

        public long PassengerID { get; set; }

        public int ControlRequestTypeID { get; set; }

        public DateTime ControlDate { get; set; }

        public long DecisionID { get; set; }

        public bool NeedDecision { get; set; }

        public DateTime? RevealDate { get; set; }

        public int OU_List_Count { get; set; }

        public bool ExactMatch { get; set; }

        [StringLength(100)]
        public string Operator { get; set; }

        [StringLength(100)]
        public string Comment { get; set; }

        [Column(TypeName = "xml")]
        public string PSWarning { get; set; }

        [Column(TypeName = "xml")]
        public string CMIORWarning { get; set; }

        public int? PostControlReasonId { get; set; }

        [StringLength(100)]
        public string RevertComment { get; set; }

        public long? ReadingId { get; set; }

        public long? ChosenDocumentScanID { get; set; }

        public virtual ControlRequestTypes ControlRequestTypes { get; set; }

        public virtual DecisionCmior DecisionCmior { get; set; }

        public virtual PostControlReason PostControlReason { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostResult> PostResult { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventLog> EventLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventLogRaw> EventLogRaw { get; set; }
    }
}
