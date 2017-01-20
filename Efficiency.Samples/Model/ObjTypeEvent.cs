namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KSBinfo.ObjTypeEvent")]
    public partial class ObjTypeEvent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public short ObjTypeID { get; set; }

        [Required]
        [StringLength(32)]
        public string Code { get; set; }

        [StringLength(5)]
        public string Type { get; set; }

        [StringLength(70)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Params { get; set; }

        public virtual ObjType ObjType { get; set; }
    }
}
