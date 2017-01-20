namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("resultguard.v_ResultsControlEmployeeList")]
    public partial class v_ResultsControlEmployeeList
    {
        public long? HeaderId { get; set; }

        public long? SectorId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EmployeeId { get; set; }

        public long? ReinforcementId { get; set; }
    }
}
