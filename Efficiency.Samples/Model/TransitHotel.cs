namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransitHotel")]
    public partial class TransitHotel
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? HotelID { get; set; }

        public DateTime? HotelOutDate { get; set; }
    }
}
