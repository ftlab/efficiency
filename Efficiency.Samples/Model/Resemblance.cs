namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("controlresult.Resemblance")]
    public partial class Resemblance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Resemblance()
        {
            Resemblance_ETResult = new HashSet<Resemblance_ETResult>();
            Resemblance_Forpost2Result = new HashSet<Resemblance_Forpost2Result>();
            Resemblance_OUListResult = new HashSet<Resemblance_OUListResult>();
            Reveal = new HashSet<Reveal>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public long? PlanPassenger_FIORUS_ID { get; set; }

        [StringLength(100)]
        public string NameInList { get; set; }

        public int? Difference { get; set; }

        public long FPDecisionID { get; set; }

        public long? ResemblanceTypeID { get; set; }

        public DateTime PrecheckDate { get; set; }

        public int? TimeSpent { get; set; }

        [Column(TypeName = "xml")]
        public string PSWarning { get; set; }

        [Column(TypeName = "xml")]
        public string CMIORWarning { get; set; }

        [StringLength(50)]
        public string Note { get; set; }

        [StringLength(50)]
        public string Checked { get; set; }

        public DateTime? CheckResultDate { get; set; }

        public int? FoundCountInOu { get; set; }

        public int? FoundCountInForpost2 { get; set; }

        public DateTime? ArrivedDate { get; set; }

        [StringLength(256)]
        public string PlanPassenger_FIORUS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PlanPassenger_BithDate { get; set; }

        [StringLength(3)]
        public string PlanPassenger_Citizenship { get; set; }

        public int? FoundCountInForpost { get; set; }

        public virtual FPDecision FPDecision { get; set; }

        public virtual ResemblanceType ResemblanceType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resemblance_ETResult> Resemblance_ETResult { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resemblance_Forpost2Result> Resemblance_Forpost2Result { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resemblance_OUListResult> Resemblance_OUListResult { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reveal> Reveal { get; set; }
    }
}
