namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FMS_StayCountry
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal CountryID { get; set; }
    }
}
