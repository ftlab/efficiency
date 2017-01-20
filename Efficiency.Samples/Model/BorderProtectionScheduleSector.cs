namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("planguard.BorderProtectionScheduleSector")]
    public partial class BorderProtectionScheduleSector
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BorderProtectionScheduleSector()
        {
            agr_ArmSession = new HashSet<agr_ArmSession>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long HeaderId { get; set; }

        public long SectorId { get; set; }

        public virtual Sector Sector { get; set; }

        public virtual BorderProtectionScheduleHeader BorderProtectionScheduleHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<agr_ArmSession> agr_ArmSession { get; set; }
    }
}
