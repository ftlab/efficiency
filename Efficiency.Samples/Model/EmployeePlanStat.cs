using System;
using System.Runtime.Serialization;

namespace Efficiency.Samples.Model
{
    [DataContract]
    public class EmployeePlanStat
    {
        [DataMember]
        public long EmployeeId { get; set; }

        [DataMember]
        public long? SectorId { get; set; }

        [DataMember]
        public long? DepartmentJobId { get; set; }

        [DataMember]
        public DateTime BeginDateTime { get; set; }

        [DataMember]
        public int Schedule { get; set; }
    }
}
