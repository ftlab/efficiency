namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("resultguard.v_ResultsControlUnaccounted")]
    public partial class v_ResultsControlUnaccounted
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long? HeaderId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EmployeeId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(300)]
        public string FullName { get; set; }

        public int? NumberByKPD { get; set; }

        public DateTime? BeginDateTime { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime EndDateTime { get; set; }

        [StringLength(100)]
        public string JobName { get; set; }

        public long? SectorId { get; set; }

        public long? DepartmentJobId { get; set; }

        public long? DepartmentGroupId { get; set; }

        public int? DIFF { get; set; }
    }
}
