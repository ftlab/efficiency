namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FirstAidPost")]
    public partial class FirstAidPost
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FirstAidPostTypeID { get; set; }
    }
}
