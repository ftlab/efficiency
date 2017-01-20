namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("resultguard.v_ResultsControlCabin")]
    public partial class v_ResultsControlCabin
    {
        public long? HeaderId { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SectorId { get; set; }

        public long? EmployeeId { get; set; }

        [StringLength(300)]
        public string FullName { get; set; }

        public int? NumberByKPD { get; set; }

        public long? DepartmentJobId { get; set; }

        public long? DepartmentGroupId { get; set; }

        public long? LocationId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ArmId { get; set; }

        [StringLength(100)]
        public string ArmName { get; set; }

        [StringLength(50)]
        public string CabinNumber { get; set; }

        public bool? HadLunch { get; set; }

        public int? CurrentPeriod { get; set; }

        public int? PassesQuantitySession { get; set; }

        public int? AvgPassTimeSession { get; set; }

        public int? PassesQuantityTotal { get; set; }

        public int? AvgPassTimeTotal { get; set; }

        public int? FaultQuantity { get; set; }

        public int? WorkTime { get; set; }

        public int? RestTime { get; set; }

        public DateTime? LunchPlanedTime { get; set; }

        [StringLength(100)]
        public string ArmDisplayName { get; set; }
    }
}
