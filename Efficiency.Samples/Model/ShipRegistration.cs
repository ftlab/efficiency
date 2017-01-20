namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShipRegistration")]
    public partial class ShipRegistration
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal ArrivalStationID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal BorderRoutingID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal CarrierTypeID { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal CarrierBCID { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "numeric")]
        public decimal CarrierRegistrationID { get; set; }
    }
}
