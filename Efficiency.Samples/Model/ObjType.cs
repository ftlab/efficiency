namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KSBinfo.ObjType")]
    public partial class ObjType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ObjType()
        {
            ObjType1 = new HashSet<ObjType>();
            ObjTypeEvent = new HashSet<ObjTypeEvent>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ID { get; set; }

        public short? ParentID { get; set; }

        [Required]
        [StringLength(32)]
        public string Code { get; set; }

        [StringLength(70)]
        public string Group { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObjType> ObjType1 { get; set; }

        public virtual ObjType ObjType2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObjTypeEvent> ObjTypeEvent { get; set; }
    }
}
