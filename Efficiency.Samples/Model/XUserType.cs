namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XUserType")]
    public partial class XUserType
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal CommitteeTypeID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal CommitteeStatusID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal XUserTypeID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DeleteFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ReadOnly { get; set; }
    }
}
