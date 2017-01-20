namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.EmployeeKaskadUser")]
    public partial class EmployeeKaskadUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public long EmployeeId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UserInfoId { get; set; }

        public virtual UserInfo UserInfo { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
