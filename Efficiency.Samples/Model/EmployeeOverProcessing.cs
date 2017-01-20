namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.EmployeeOverProcessing")]
    public partial class EmployeeOverProcessing
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long EmployeeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public byte Hours { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
