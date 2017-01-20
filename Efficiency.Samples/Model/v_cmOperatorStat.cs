namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_cmOperatorStat
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal UserInfoID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string ComputerName { get; set; }

        public int? isDocumentFault { get; set; }

        public int? isAdministrativeCase { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string LoginName { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int isTemporaryBlocked { get; set; }
    }
}
