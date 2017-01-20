namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.EmployeeCard")]
    public partial class EmployeeCard
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long EmployeeId { get; set; }

        [Required]
        [StringLength(50)]
        public string CardId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
