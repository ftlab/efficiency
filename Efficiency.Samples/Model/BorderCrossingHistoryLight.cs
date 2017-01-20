namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("controlresult.BorderCrossingHistoryLight")]
    public partial class BorderCrossingHistoryLight
    {
        public long? AirlineId { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string Arm { get; set; }

        public DateTime? Birthday { get; set; }

        public byte? BirthdayType { get; set; }

        public long? CitizenshipId { get; set; }

        public long? CrossingLabelId { get; set; }

        public long? DecisionId { get; set; }

        public long? DepartureCityId { get; set; }

        public long? DepartureCountryId { get; set; }

        public int? Direction { get; set; }

        [StringLength(100)]
        public string FamilyLat { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string FamilyRus { get; set; }

        [StringLength(100)]
        public string FlightNumber { get; set; }

        public DateTime? FlightTime { get; set; }

        public long? Id { get; set; }

        [StringLength(100)]
        public string NameLat { get; set; }

        [StringLength(100)]
        public string NameRus { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime OperationTime { get; set; }

        [StringLength(201)]
        public string OperatorPC { get; set; }

        public long? PassengerTypeId { get; set; }

        public long? PermanentResidenceId { get; set; }

        public long? PurposeId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string Sex { get; set; }

        public long? SubdivisionId { get; set; }
    }
}
