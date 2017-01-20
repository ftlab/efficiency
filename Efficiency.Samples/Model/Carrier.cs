namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Carrier")]
    public partial class Carrier
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal CarrierTypeID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal CarrierID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ColorID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TransportCompanyID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CountryID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CityID { get; set; }

        [StringLength(100)]
        public string RegisterNumber { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FlagCountryID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Tonnage { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PhotoID { get; set; }
    }
}
