namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KSBinfo.Obj_Person")]
    public partial class Obj_Person
    {
        public int ID { get; set; }

        [Required]
        [StringLength(40)]
        public string Code { get; set; }

        public DateTime? CardDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Expired { get; set; }

        [StringLength(255)]
        public string FIO { get; set; }
    }
}
