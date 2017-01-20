namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarrierRegistration")]
    public partial class CarrierRegistration
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

        [Column(TypeName = "numeric")]
        public decimal RegistrationTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CarrierDecisionID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UserInfoID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ARMID { get; set; }

        [Required]
        [StringLength(100)]
        public string ComputerName { get; set; }

        public DateTime RegistrationTime { get; set; }
    }
}
