namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stat.v_EventLog")]
    public partial class v_EventLog
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short EventTypeId { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool isCustomEvent { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime EventDate { get; set; }

        public string Description { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short PriorityId { get; set; }

        public long? MapObjectId { get; set; }

        public long? EmployeeId { get; set; }

        public long? PassengerId { get; set; }

        public long? KsbEventId { get; set; }

        public long? CustomEventPropertiesId { get; set; }
    }
}
