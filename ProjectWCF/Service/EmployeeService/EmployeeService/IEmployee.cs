using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    [ServiceContract]
    public interface IEmployee
    {
        [OperationContract]
       List<EmpData> GetEmp();

        [OperationContract]
        EmpData GetEmpById(int id);

        [OperationContract]
        EmpData GetEmpByName(string name);

        [OperationContract]
        int DelEmp(int id);

        [OperationContract]
        int UpdateEmp(EmpData emp);

        [OperationContract]
        int InsertEmp(EmpData emp);

        [OperationContract]
        List<ProData> GetPro();

        [OperationContract]
        ProData GetProById(int id);

        [OperationContract]
        int DelPro(int id);

        [OperationContract]
        int UpdatePro(ProData pro);

        [OperationContract]
        int InsertPro(string name);

    }
}
