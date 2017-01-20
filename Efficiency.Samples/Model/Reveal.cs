namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("controlresult.Reveal")]
    public partial class Reveal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reveal()
        {
            Resemblance_ETResult = new HashSet<Resemblance_ETResult>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public long ResemblanceID { get; set; }

        public DateTime? RevealDate { get; set; }

        public int? AirlineID { get; set; }

        [StringLength(255)]
        public string Comment { get; set; }

        [StringLength(50)]
        public string Operator { get; set; }

        public long? ExportId { get; set; }

        public bool IsExport { get; set; }

        public byte? Direction { get; set; }

        [StringLength(4)]
        public string Job { get; set; }

        public virtual Resemblance Resemblance { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resemblance_ETResult> Resemblance_ETResult { get; set; }
    }
}
