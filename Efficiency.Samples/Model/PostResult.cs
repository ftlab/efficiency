namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("controlresult.PostResult")]
    public partial class PostResult
    {
        public long ID { get; set; }

        public long ControlID { get; set; }

        public long? ResemblanceID { get; set; }

        public long? Forpost2Id { get; set; }

        [MaxLength(16)]
        public byte[] OU_List_Hash { get; set; }

        public double OU_Weight { get; set; }

        public bool IsDecisionTask { get; set; }

        public virtual ControlRequest ControlRequest { get; set; }
    }
}
