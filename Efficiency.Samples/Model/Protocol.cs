namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KSBinfo.Protocol")]
    public partial class Protocol
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Protocol()
        {
            EventLog = new HashSet<EventLog>();
            EventLogRaw = new HashSet<EventLogRaw>();
            EventLog1 = new HashSet<EventLog>();
        }

        public long ID { get; set; }

        [Required]
        [StringLength(32)]
        public string ObjType { get; set; }

        [Required]
        [StringLength(32)]
        public string Event { get; set; }

        [Required]
        [StringLength(60)]
        public string ObjectID { get; set; }

        [StringLength(50)]
        public string RegionID { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(50)]
        public string Owner { get; set; }

        public Guid? Agent { get; set; }

        [StringLength(50)]
        public string MessageType { get; set; }

        [StringLength(255)]
        public string Param0 { get; set; }

        [StringLength(60)]
        public string Param1 { get; set; }

        [StringLength(255)]
        public string Param2 { get; set; }

        [StringLength(255)]
        public string Param3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventLog> EventLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventLogRaw> EventLogRaw { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventLog> EventLog1 { get; set; }
    }
}
