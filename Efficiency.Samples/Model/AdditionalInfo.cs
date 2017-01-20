namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdditionalInfo")]
    public partial class AdditionalInfo
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal AdditionalInfoTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DestinationCountryID { get; set; }

        [StringLength(255)]
        public string ArbitraryInfo { get; set; }

        [StringLength(255)]
        public string PRCityName { get; set; }

        [StringLength(255)]
        public string VaucherInfo { get; set; }
    }
}
