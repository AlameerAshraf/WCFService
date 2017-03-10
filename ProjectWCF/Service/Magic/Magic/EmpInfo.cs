using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Magic
{
    [DataContract]
    public class EmpInfo
    {
        [DataMember]
        public int EmpId { get; set; }
        [DataMember]
        public string EmpName { get; set; }
        [DataMember]
        public decimal EmpSalary { get; set; }
        [DataMember]
        public string EmpAddress { get; set; }
        [DataMember]
        public int ProjectId { get; set; }
        [DataMember]
        public string ProjectName { get; set; }


    }
}