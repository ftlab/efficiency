namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanPerson.PassengerFileTypeExt")]
    public partial class PassengerFileTypeExt
    {
        public byte ID { get; set; }

        public byte FileTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string Ext { get; set; }

        public virtual PassengerFileType PassengerFileType { get; set; }
    }
}
