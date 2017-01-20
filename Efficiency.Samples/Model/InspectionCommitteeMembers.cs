namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("resultguard.InspectionCommitteeMembers")]
    public partial class InspectionCommitteeMembers
    {
        public int ID { get; set; }

        public int InspectionCommitteeID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public long? EmployeeId { get; set; }

        public long? BorderProtectionScheduleCronometryId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? UserInfoID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? XUserTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? XUserListID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CommitteeStatusID { get; set; }

        public virtual InspectionCommittee InspectionCommittee { get; set; }
    }
}
