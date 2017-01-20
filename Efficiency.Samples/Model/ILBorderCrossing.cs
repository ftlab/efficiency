namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("controlresult.ILBorderCrossing")]
    public partial class ILBorderCrossing
    {
        public long? Airlines { get; set; }

        [StringLength(100)]
        public string ArrivalStation { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string Arm { get; set; }

        public DateTime? Birthday { get; set; }

        public byte? BirthdayType { get; set; }

        public long? Citizenship { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        public long? CmiorDecision { get; set; }

        [StringLength(100)]
        public string Comment { get; set; }

        public DateTime? ControlDate { get; set; }

        public long? ControlId { get; set; }

        public long? DepartureCountryId { get; set; }

        public int? Direction { get; set; }

        public int? DocumentCategoryIcao { get; set; }

        public long? DocumentCategoryId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string DocumentNumber { get; set; }

        public bool? ExactMatch { get; set; }

        [StringLength(201)]
        public string FioLat { get; set; }

        [StringLength(201)]
        public string FioRus { get; set; }

        [StringLength(100)]
        public string Flight { get; set; }

        public DateTime? FlightTime { get; set; }

        public long? ForpostDecision { get; set; }

        public DateTime? Identified { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime OperationTime { get; set; }

        [StringLength(100)]
        public string Operator { get; set; }

        [StringLength(201)]
        public string OperatorPC { get; set; }

        public int? OUListCount { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PassengerId { get; set; }

        public long? ReadingId { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string StatusOpk { get; set; }
    }
}
