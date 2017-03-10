using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Employee" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Employee.svc or Employee.svc.cs at the Solution Explorer and start debugging.
    public class Employee : IEmployee
    {
        WCFProjectEntities ent = new WCFProjectEntities();
        employee em = new employee();
        project pr = new project();
        List<EmpData> lemp = new List<EmpData>();
        List<ProData> lpro = new List<ProData>();
        
        public int DelEmp(int id)
        {
            int t=0;
            for (int i = 0; i < lemp.Count(); i++)
            {
                if (lemp[i].empid == id)
                {
                     lemp.Remove(lemp[i]);
                    t = 1;
                }
                else
                {
                    t = 0;
                }
            }
            return t;
        }

        public int DelPro(int id)
        {
            int t = 0;
            for (int i = 0; i < lpro.Count(); i++)
            {
                if (lpro[i].projid == id)
                {
                    lpro.Remove(lpro[i]);
                    t = 1;
                }
                else
                {
                    t = 0;
                }
            }
            return t;
        }

        public List<EmpData> GetEmp()
        {
            EmpData Data;
            var empdata1 = (from i in ent.employees
                           select i).ToList();
            for(int i  =0; i < empdata1.Count(); i++)
            {
                Data = new EmpData();
                Data.empname = empdata1[i].empname;
                Data.empsalary=int.Parse(empdata1[i].empsalary.ToString());
                Data.empAddress = empdata1[i].empAddress;
                lemp.Add(Data);
            }
            return lemp;
        }

        public EmpData GetEmpById(int id)
        {
            EmpData Data=new EmpData();
           
            for (int i = 0; i < lemp.Count(); i++)
            {
                if (lemp[i].empid==id)
                {
                    Data = lemp[i];
                }  
            }
            return Data;
        }

        public EmpData GetEmpByName(string name)
        {
            EmpData Data = new EmpData();

            for (int i = 0; i < lemp.Count(); i++)
            {
                if (lemp[i].empname == name)
                {
                    Data = lemp[i];
                }
            }
            return Data;
        }
        
        public List<ProData> GetPro()
        {
            ProData Data;
            var prodata1 = (from i in ent.projects
                            select i).ToList();
            for (int i = 0; i < prodata1.Count(); i++)
            {
                Data = new ProData();
                Data.projname = prodata1[i].projname;
                lpro.Add(Data);
            }
            return lpro;
        }

        public ProData GetProById(int id)
        {
            ProData Data = new ProData();

            for (int i = 0; i < lemp.Count(); i++)
            {
                if (lemp[i].PId == id)
                {
                    Data = lpro[i];
                }
            }
            return Data;
        }

        public int InsertEmp(EmpData emp)
        {
            throw new NotImplementedException();
        }

        public int InsertPro(string name)
        {
            throw new NotImplementedException();
        }

        public int UpdateEmp(EmpData emp)
        {
            throw new NotImplementedException();
        }

        public int UpdatePro(ProData pro)
        {
            throw new NotImplementedException();
        }

        
    }
}
