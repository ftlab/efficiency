namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("resultguard.ControlledPersonOfficerHistory")]
    public partial class ControlledPersonOfficerHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long ControlledPersonId { get; set; }

        public long AppointedResponsibleOfficerId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ChangedDateTime { get; set; }

        public long ChangedEmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Employee Employee1 { get; set; }

        public virtual ControlledPerson ControlledPerson { get; set; }
    }
}
