namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarrierModel")]
    public partial class CarrierModel
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal CarrierTypeID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal CarrierID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal ModelTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ModelCategoryID { get; set; }
    }
}
