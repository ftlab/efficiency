namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logptk.Reading")]
    public partial class Reading
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reading()
        {
            DocumentScan = new HashSet<DocumentScan>();
            ReadMRZ = new HashSet<ReadMRZ>();
            ReadRFID = new HashSet<ReadRFID>();
        }

        public long ID { get; set; }

        public Guid AID { get; set; }

        public long Registration_ID { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Changed { get; set; }

        public int? DocumentType { get; set; }

        public DateTime? DocumInsertReader { get; set; }

        public DateTime? DocumRemoveReader { get; set; }

        public DateTime? IncorrectReadPassport { get; set; }

        public DateTime? ErrorDetectionDocum { get; set; }

        public DateTime? ErrorChecksum { get; set; }

        public DateTime? UserCancelReadChip { get; set; }

        public DateTime? DocumNotRecognized { get; set; }

        public TimeSpan? TimeReadDocument { get; set; }

        public TimeSpan? TimeReadVisa { get; set; }

        public TimeSpan? TimeReadRFID { get; set; }

        [StringLength(50)]
        public string National { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(256)]
        public string DocumentName { get; set; }

        [StringLength(2048)]
        public string ArchivePath { get; set; }

        public byte[] Document_IR { get; set; }

        public byte[] Snapshot { get; set; }

        public byte[] Document_WHITE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentScan> DocumentScan { get; set; }

        public virtual Registration Registration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReadMRZ> ReadMRZ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReadRFID> ReadRFID { get; set; }
    }
}
