namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("controlresult.BorderCrossingHistory")]
    public partial class BorderCrossingHistory
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
        public string DocumentBlankNumber { get; set; }

        public long? DocumentCategoryId { get; set; }

        public long? DocumentCountryId { get; set; }

        public DateTime? DocumentIssueDate { get; set; }

        [StringLength(100)]
        public string DocumentIssueOrganization { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string DocumentNumber { get; set; }

        [StringLength(30)]
        public string DocumentSeria { get; set; }

        public long? DocumentStatusId { get; set; }

        public DateTime? DocumentValidDate { get; set; }

        [StringLength(100)]
        public string FamilyLat { get; set; }

        [Key]
        [Column(Order = 2)]
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
        [Column(Order = 3)]
        public DateTime OperationTime { get; set; }

        [StringLength(201)]
        public string OperatorPC { get; set; }

        public long? PassengerTypeId { get; set; }

        public long? PermanentResidenceId { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }

        public long? PhotoId { get; set; }

        public long? PurposeId { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string Sex { get; set; }

        public long? SubdivisionId { get; set; }

        public long? SuspectFaultTypeId { get; set; }
    }
}
