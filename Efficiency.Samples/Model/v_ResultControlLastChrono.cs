namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("resultguard.v_ResultControlLastChrono")]
    public partial class v_ResultControlLastChrono
    {
        public long? HeaderId { get; set; }

        public long? SectorId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EmployeeId { get; set; }

        public long? LastId { get; set; }
    }
}
