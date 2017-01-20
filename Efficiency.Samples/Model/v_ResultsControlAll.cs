namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("resultguard.v_ResultsControlAll")]
    public partial class v_ResultsControlAll
    {
        public long? HeaderId { get; set; }

        public long? SectorId { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EmployeeId { get; set; }

        [Key]
        [Column(Order = 1)]
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

        public long? ArmId { get; set; }

        [StringLength(100)]
        public string ArmName { get; set; }

        [StringLength(50)]
        public string CabinNumber { get; set; }

        public long? LastId { get; set; }

        public bool? HadLunch { get; set; }

        public int? CurrentPeriod { get; set; }

        public int? PassesQuantitySession { get; set; }

        public int? AvgPassTimeSession { get; set; }

        public int? PassesQuantityTotal { get; set; }

        public int? AvgPassTimeTotal { get; set; }

        public int? FaultQuantity { get; set; }

        public int? WorkTime { get; set; }

        public int? RestTime { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RestCount { get; set; }

        public DateTime? LunchPlanedTime { get; set; }

        public long? ReinforcementId { get; set; }

        [StringLength(100)]
        public string ArmDisplayName { get; set; }
    }
}
