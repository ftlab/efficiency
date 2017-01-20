namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("param.OperatorStatistics")]
    public partial class OperatorStatistics
    {
        [StringLength(100)]
        public string UserLogin { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BorderCrossing_ID { get; set; }

        public int? OU_Count { get; set; }

        public int? OU_Direct { get; set; }

        public DateTime? RegStartTime { get; set; }

        public TimeSpan? RegTimespan { get; set; }

        public DateTime? RegEndTime { get; set; }
    }
}
