namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("controlresult.ILPersonRegistration")]
    public partial class ILPersonRegistration
    {
        public long? Airlines { get; set; }

        [StringLength(100)]
        public string ArrivalStation { get; set; }

        [StringLength(50)]
        public string Arm { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }

        public byte? BirthdayType { get; set; }

        [StringLength(30)]
        public string Citizenship { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CmiorDecision { get; set; }

        [StringLength(100)]
        public string Comment { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime ControlDate { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ControlId { get; set; }

        public long? DepartureCountryId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Direction { get; set; }

        [StringLength(30)]
        public string DocumentCategoryIcao { get; set; }

        public long? DocumentCategoryId { get; set; }

        [StringLength(15)]
        public string DocumentNumber { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool ExactMatch { get; set; }

        [StringLength(257)]
        public string FioLat { get; set; }

        [StringLength(257)]
        public string FioRus { get; set; }

        [StringLength(100)]
        public string Flight { get; set; }

        public DateTime? FlightTime { get; set; }

        public long? ForpostDecision { get; set; }

        public DateTime? Identified { get; set; }

        public DateTime? OperationTime { get; set; }

        [StringLength(100)]
        public string Operator { get; set; }

        [StringLength(100)]
        public string OperatorPC { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OUListCount { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PassengerId { get; set; }

        public long? ReadingId { get; set; }

        [StringLength(3)]
        public string Sex { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string StatusOpk { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ControlRequestTypeId { get; set; }

        public long? ArmId { get; set; }

        public long? SectorId { get; set; }
    }
}
