namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.AirlineCode")]
    public partial class AirlineCode
    {
        public int ID { get; set; }

        [Required]
        [StringLength(3)]
        public string Code { get; set; }

        public byte AirlineCodeTypeID { get; set; }

        public int AirlineID { get; set; }

        public virtual Airline Airline { get; set; }

        public virtual AirlineCodeType AirlineCodeType { get; set; }
    }
}
