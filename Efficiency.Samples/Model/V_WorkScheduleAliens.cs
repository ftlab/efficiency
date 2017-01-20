namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("controlresult.V_WorkScheduleAliens")]
    public partial class V_WorkScheduleAliens
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ResemblanceId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long RevealId { get; set; }

        [StringLength(256)]
        public string PlanPassenger_FIORUS { get; set; }

        [StringLength(3)]
        public string PlanPassenger_Citizenship { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PlanPassenger_BithDate { get; set; }

        public DateTime? scheduleTimeDep { get; set; }

        public DateTime? scheduleTimeArr { get; set; }

        public DateTime? PrecheckDate { get; set; }

        public DateTime? CheckResultDate { get; set; }

        [StringLength(50)]
        public string Checked { get; set; }

        [StringLength(256)]
        public string Enemy_PlanPassenger_FIORUS { get; set; }

        [StringLength(3)]
        public string Enemy_PlanPassenger_Citizenship { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Enemy_PlanPassenger_BithDate { get; set; }

        [Column(TypeName = "image")]
        public byte[] ImaageSource { get; set; }

        public long? DepartmentWorkScheduleId { get; set; }

        [StringLength(10)]
        public string FlightNumberIATA { get; set; }
    }
}
