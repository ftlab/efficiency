namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logptk.Starting")]
    public partial class Starting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Starting()
        {
            Authorization = new HashSet<Authorization>();
            Errors = new HashSet<Errors>();
            PakLogFile = new HashSet<PakLogFile>();
        }

        public long ID { get; set; }

        public Guid AID { get; set; }

        public long? ArmID { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Changed { get; set; }

        public DateTime? Start { get; set; }

        public DateTime? WaitUser { get; set; }

        [StringLength(50)]
        public string SizeMem { get; set; }

        [StringLength(50)]
        public string FreeMem { get; set; }

        [StringLength(50)]
        public string NameComp { get; set; }

        [StringLength(50)]
        public string NameUser { get; set; }

        [StringLength(256)]
        public string FolderRun { get; set; }

        [StringLength(256)]
        public string FolderWork { get; set; }

        [StringLength(16)]
        public string Mode { get; set; }

        public DateTime? IncorComplSes { get; set; }

        public virtual Arm1 Arm1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Authorization> Authorization { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Errors> Errors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PakLogFile> PakLogFile { get; set; }
    }
}
