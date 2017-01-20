namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.CarrierParkingArea")]
    public partial class CarrierParkingArea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarrierParkingArea()
        {
            LocationRoute_CarrierParkingArea = new HashSet<LocationRoute_CarrierParkingArea>();
        }

        public long Id { get; set; }

        [Required]
        [StringLength(15)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationRoute_CarrierParkingArea> LocationRoute_CarrierParkingArea { get; set; }
    }
}
