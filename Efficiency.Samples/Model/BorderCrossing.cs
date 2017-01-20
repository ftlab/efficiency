namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BorderCrossing")]
    public partial class BorderCrossing
    {
        [Column(TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ArrivalStationID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CrossingLabelID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BorderRoutingID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FlightID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CrossingOperationID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PassengerTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PurposeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DecisionID { get; set; }

        [StringLength(100)]
        public string TicketNumber { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CheckIN { get; set; }

        [Column("_TelegramID")]
        public int? C_TelegramID { get; set; }

        [Column("_TelegramPreparationFlag")]
        public int? C_TelegramPreparationFlag { get; set; }

        [Column("_DataCrossing1")]
        public DateTime? C_DataCrossing1 { get; set; }

        [Column("_DataCrossing2")]
        public DateTime? C_DataCrossing2 { get; set; }

        [Column("_Post")]
        [StringLength(100)]
        public string C_Post { get; set; }

        [Column("_FullData")]
        public int? C_FullData { get; set; }

        [Column("_NumberCabin")]
        public int? C_NumberCabin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AddedMakeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? InOutArrivalStationID { get; set; }

        public DateTime? InOutCrossingDate { get; set; }

        [StringLength(255)]
        public string TouristOrgAccount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MigrationCardID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StayCountryID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StayRegionID { get; set; }

        [StringLength(255)]
        public string StayAddress { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ProfessionID { get; set; }

        public DateTime? ResidenceFrom { get; set; }

        public DateTime? ResidenceTo { get; set; }

        [StringLength(255)]
        public string InvitationOrganization { get; set; }

        [StringLength(255)]
        public string InvOrganizationAddress { get; set; }

        public Guid? GlobalIdentifier { get; set; }
    }
}
