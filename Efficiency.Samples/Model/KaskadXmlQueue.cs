namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KaskadXmlQueue")]
    public partial class KaskadXmlQueue
    {
        public long Id { get; set; }

        [Column(TypeName = "xml")]
        public string Body { get; set; }
    }
}
