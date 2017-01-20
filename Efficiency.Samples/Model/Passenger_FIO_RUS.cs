namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanPerson.Passenger_FIO_RUS")]
    public partial class Passenger_FIO_RUS
    {
        public long ID { get; set; }

        public long PassengerID { get; set; }

        [Required]
        [StringLength(3)]
        public string LangCode { get; set; }

        [Required]
        [StringLength(256)]
        public string FIO { get; set; }

        public virtual Passenger1 Passenger1 { get; set; }
    }
}
