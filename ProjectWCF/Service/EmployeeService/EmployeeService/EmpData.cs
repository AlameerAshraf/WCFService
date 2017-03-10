using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace EmployeeService
{
    [DataContract]
    public class EmpData
    {
        public int empid { get; set; }


        [DataMember]
        public string empname { get; set; }

        [DataMember]
        public int empsalary { get; set; }


        [DataMember]
        public string empAddress { get; set; }

        [DataMember]
        public int PId { get; set; }

    }
}