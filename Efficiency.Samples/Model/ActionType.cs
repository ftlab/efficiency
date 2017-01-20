namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActionType")]
    public partial class ActionType
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal ActionGroupID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal ActionTypeID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(255)]
        public string DescString1 { get; set; }

        [StringLength(255)]
        public string DescString2 { get; set; }

        [StringLength(255)]
        public string DescString3 { get; set; }

        [StringLength(255)]
        public string DescNumber1 { get; set; }

        [StringLength(255)]
        public string DescNumber2 { get; set; }

        [StringLength(255)]
        public string DescNumber3 { get; set; }

        [StringLength(255)]
        public string DescDate1 { get; set; }

        [StringLength(255)]
        public string DescDate2 { get; set; }

        [StringLength(255)]
        public string DescDate3 { get; set; }

        [StringLength(255)]
        public string DescString4 { get; set; }

        [StringLength(255)]
        public string DescString5 { get; set; }

        [StringLength(255)]
        public string DescString6 { get; set; }

        [StringLength(255)]
        public string DescString7 { get; set; }

        [StringLength(255)]
        public string DescString8 { get; set; }

        [StringLength(255)]
        public string DescNumber4 { get; set; }

        [StringLength(255)]
        public string DescNumber5 { get; set; }
    }
}
