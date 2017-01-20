namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("resultguard.v_KaskadControlledPerson")]
    public partial class v_KaskadControlledPerson
    {
        public long? BorderCrossingID { get; set; }

        public long? DirectionID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string Direction { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Family { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public long? NationalityID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SexID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(131)]
        public string Dul { get; set; }

        [StringLength(100)]
        public string FlightNumber { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FlightDateTime { get; set; }

        public long? AirlineFlightID { get; set; }

        public long? StationID { get; set; }

        public long? CountryFlightID { get; set; }

        public long? CityFlightID { get; set; }

        public long? DecisionID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string Decision { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime OperationTime { get; set; }

        public DateTime? MinOperationTime { get; set; }
    }
}
