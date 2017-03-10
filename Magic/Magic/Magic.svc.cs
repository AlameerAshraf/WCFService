using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Magic
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Magic" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Magic.svc or Magic.svc.cs at the Solution Explorer and start debugging.
    public class Magic : IMagic
    {
        Emp Main = new Emp();
        employee emp = new employee();
        project pro = new project();
        public int DeleteEmployeeID(string id)
        {
            int j = 0;
            int emid = int.Parse(id);

            var DelEmpId = (from i
                            in Main.employees
                            where i.empid == emid
                            select i).Single();
         
            Main.employees.Remove(DelEmpId);
            Main.SaveChanges();
            j = 1;
            return j;
        }


        public int DeleteProjecID(string id)
        {

            int j = 0;
            int prid = int.Parse(id);

            var DelproId = (from i
                            in Main.projects
                            where i.projId == prid
                            select i).Single();

            Main.projects.Remove(DelproId);
            Main.SaveChanges();
            j = 1;
            return j;
        }

        
        public List<EmpInfo> GetAllEmployees()
        {
            var list = (from p
                        in Main.employees
                        join pp in Main.projects on p.PId equals pp.projId
                        select new EmpInfo { EmpId = p.empid , EmpName = p.empname , EmpAddress = p.empAddress , EmpSalary = p.empsalary , ProjectId = pp.projId , ProjectName = pp.projname }).ToList();

            return list;
        }

        public List<project> GetAllProject()
        {
             return Main.projects.ToList();
           
        }

        public employee GetEmployeeID(string id)
        {
            int emid = int.Parse(id);

            var employee1 = (from i
                             in Main.employees
                             where i.empid == emid
                             select i).First();

            return employee1;
            

        }

        public employee GetEmployeeName(string Name)
        {
            var employee1 = (from i
                             in Main.employees
                             where i.empname == Name
                             select i).Single();
            return employee1;
        }

        public project GetProjectID(string id)
        {
            int prid = int.Parse(id);
            var project1 = (from i
                       in Main.projects
                            where i.projId == prid
                            select i).First();
            return project1;
        }
        
        public List<employee> GetProjectName(string Name)
        {

            var project1 = (from i
                            in Main.projects
                            join f in Main.employees on i.projId equals f.PId
                            where i.projname == Name
                            select f).ToList();
            return project1;

        }

        public int InsertEmployee(employee emp)
        {
            int t = 0;
            var beforeCount = (from i
                               in Main.employees
                               select i).Count();
            Main.employees.Add(emp);
            Main.SaveChanges();
            var afterCount = (from i
                              in Main.employees
                               select i).Count();
            if(afterCount>beforeCount)
            {
                t = 1;
            }
            else if(afterCount==beforeCount)
            {
                t = 0;
            }
            else
            {
                t = 2;
            }
            return t;
        }

        public int InsertProjet(project pro)
        {
            int t = 0;
            var beforeCount = (from i
                               in Main.projects
                               select i).Count();
            Main.projects.Add(pro);
            Main.SaveChanges();
            var afterCount = (from i
                              in Main.projects
                              select i).Count();
            if (afterCount > beforeCount)
            {
                t = 1;
            }
            else if (afterCount == beforeCount)
            {
                t = 0;
            }
            else
            {
                t = 2;
            }
            return t;
        }

        public int UpdateEmployee(employee em)
        {
            int EmpId = em.empid;
            int RetValCheck = 6; 

            var Updated = (from Emp
                           in Main.employees
                           where Emp.empid == EmpId
                           select Emp).Single();

            Updated.empname = em.empname;
            Updated.empsalary = em.empsalary;
            Updated.empAddress = em.empAddress;
            Updated.PId = em.PId;

            Main.employees.Attach(Updated);
            Main.Entry(Updated).State = System.Data.Entity.EntityState.Modified;
            Main.SaveChanges();

            var Table = (from Emp
                         in Main.employees
                         where Emp.empname == em.empname
                         select EmpId).First();

           if (Table == em.empid)
            {
                RetValCheck = 1; 
            }
           else
            {
                RetValCheck = 0;
            }
           
            return RetValCheck;
        }

        public int UpdateProjec()
        {
            throw new NotImplementedException();
        }

        //public int DeleteEmployeeID(string id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
