namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CommitteeMan")]
    public partial class CommitteeMan
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal CommitteeTypeID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal CommitteeID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal CommitteeManID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CommitteeStatusID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? XUserTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? XUserListID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? UserInfoID { get; set; }
    }
}
