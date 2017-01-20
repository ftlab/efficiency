namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanPerson.I_EGISOTB_Passenger")]
    public partial class I_EGISOTB_Passenger
    {
        public long Id { get; set; }

        public long FlightID { get; set; }

        [StringLength(30)]
        public string CountryIssue { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateBirth { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        [Required]
        [StringLength(300)]
        public string FIOPassenger { get; set; }

        public string Error { get; set; }

        public virtual I_EGISOTB_Flight I_EGISOTB_Flight { get; set; }
    }
}
