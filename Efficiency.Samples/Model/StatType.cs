namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StatType")]
    public partial class StatType
    {
        [Column(TypeName = "numeric")]
        public decimal StatTypeID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(255)]
        public string DescStatString1 { get; set; }

        [StringLength(255)]
        public string DescStatString2 { get; set; }

        [StringLength(255)]
        public string DescStatString3 { get; set; }

        [StringLength(255)]
        public string DescStatNumber1 { get; set; }

        [StringLength(255)]
        public string DescStatNumber2 { get; set; }

        [StringLength(255)]
        public string DescStatNumber3 { get; set; }

        [StringLength(255)]
        public string DescStatDate1 { get; set; }

        [StringLength(255)]
        public string DescStatDate2 { get; set; }

        [StringLength(255)]
        public string DescStatDate3 { get; set; }
    }
}
