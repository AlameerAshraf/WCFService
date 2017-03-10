using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Magic
{
    [ServiceContract]
    public interface IMagic
    {
        [OperationContract]
        [WebGet(UriTemplate ="Employees")]
        List<EmpInfo> GetAllEmployees();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Employee/{id}")]
        employee GetEmployeeID(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Employee?Name={Name}")]
        employee GetEmployeeName(string Name);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "UpdateEmployee")]
        int UpdateEmployee(employee em);


        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "DeleteEmployee/{id}")]
        int DeleteEmployeeID(string id);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "InsertEmployee")]
        int InsertEmployee(employee emp);


        [OperationContract]
        [WebGet(UriTemplate = "Projects")]
        List<project> GetAllProject();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Project/{id}")]
        project GetProjectID(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Project?pro={project}")]
        List<employee> GetProjectName(string project);

        //[OperationContract]
        //[WebInvoke(Method = "PUT", UriTemplate = "UpdateProjec")]
        //int UpdateProjec();   // 0 Failed , 1 Done , 2 Noid


        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "DeleteProjec/{id}")]
        int DeleteProjecID(string id);  // 0 Failed , 1 Done , 2 Noid 

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "InsertProjet")]
        int InsertProjet(project pro);




    }
}
