namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("param.Dashboard_Control")]
    public partial class Dashboard_Control
    {
        public int ID { get; set; }

        public int? Dashboard_Form_ID { get; set; }

        public int? Statistic_Control_ID { get; set; }

        public virtual Dashboard_Form Dashboard_Form { get; set; }

        public virtual Statistic_Control Statistic_Control { get; set; }
    }
}
