namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.WorkingCalendar")]
    public partial class WorkingCalendar
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long WorkScheduleTypeId { get; set; }

        public long DayTypeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime CalendarDate { get; set; }

        public virtual WorkingDayType WorkingDayType { get; set; }

        public virtual WorkScheduleType WorkScheduleType { get; set; }
    }
}
