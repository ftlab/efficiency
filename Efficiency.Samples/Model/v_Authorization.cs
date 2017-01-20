namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("resultguard.v_Authorization")]
    public partial class v_Authorization
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long AuthorizationId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Starting_ID { get; set; }

        [StringLength(100)]
        public string UserLogin { get; set; }

        [StringLength(50)]
        public string NameComp { get; set; }

        [StringLength(50)]
        public string NameUser { get; set; }

        public DateTime? Start { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? UserInfoID { get; set; }

        public long? ArmId { get; set; }

        public long? EmployeeId { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime Created { get; set; }

        public DateTime? Changed { get; set; }
    }
}
