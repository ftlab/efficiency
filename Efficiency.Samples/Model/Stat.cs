namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stat")]
    public partial class Stat
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal OperationID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal StatTypeID { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal StatObjectID { get; set; }

        [StringLength(255)]
        public string StatString1 { get; set; }

        [StringLength(255)]
        public string StatString2 { get; set; }

        [StringLength(255)]
        public string StatString3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StatNumber1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StatNumber2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StatNumber3 { get; set; }

        public DateTime? StatDate1 { get; set; }

        public DateTime? StatDate2 { get; set; }

        public DateTime? StatDate3 { get; set; }
    }
}
