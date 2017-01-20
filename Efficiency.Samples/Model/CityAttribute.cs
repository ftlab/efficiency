namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CityAttribute")]
    public partial class CityAttribute
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal CountryID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal CityID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal CityAttributeTypeID { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal CityAttributeID { get; set; }

        [StringLength(30)]
        public string AirportCod { get; set; }

        [StringLength(30)]
        public string ICAOCod { get; set; }
    }
}
