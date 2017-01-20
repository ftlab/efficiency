namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("resultguard.v_ResultsControlReinforcements")]
    public partial class v_ResultsControlReinforcements
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long? HeaderId { get; set; }

        public long? SectorId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EmployeeId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(300)]
        public string FullName { get; set; }

        public int? NumberByKPD { get; set; }

        public long? DepartmentJobId { get; set; }

        public long? DepartmentGroupId { get; set; }

        [StringLength(100)]
        public string JobName { get; set; }

        public long? LocationId { get; set; }

        [StringLength(50)]
        public string LocationName { get; set; }

        public int? TimeInterval { get; set; }

        public long? LastId { get; set; }
    }
}
