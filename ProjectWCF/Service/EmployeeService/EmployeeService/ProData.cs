using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace EmployeeService
{
    [DataContract]
    public class ProData
    {
        public int projid { get; set; }

        [DataMember]
        public string projname { get; set; }
    }
}