using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using System.Collections.Specialized;

namespace ServiceConsumer
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //WebClient MyClient = new WebClient();
            //MyClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            //string Array = MyClient.DownloadString("http://localhost:8258/Magic.svc/Employees");
            //TextBox1.Text = Array;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            // myclient.Headers.Add("Content-Type", "text");
            // myclient.Encoding = Encoding.UTF8;

          //    WebClient myclient = new WebClient();
          //    myclient.Headers[HttpRequestHeader.ContentType] = "application/json";
           //    EmpInfo ss = new EmpInfo();
           //    ss.EmpId = 3;
        //    ss.EmpName = "ALBERT";
        //    ss.EmpSalary = 20555;
        //    ss.EmpAddress = "asasasas";
        //    ss.ProjectName = "sdsds";
        //    ss.ProjectId = 5;

        //string Obj = JsonConvert.SerializeObject(ss);
        
        //string replay = myclient.UploadString("http://localhost:8258/Magic.svc/InsertEmployee", "POST", Obj);
        //TextBox1.Text = replay;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //WebClient myclient = new WebClient();
            //myclient.Headers[HttpRequestHeader.ContentType] = "application/json";
            //EmpInfo ss = new EmpInfo();
            //ss.EmpAddress = "a7a";
            //ss.EmpId = 7;
            //ss.EmpName = "ALBERT";
            //ss.EmpSalary = 20555;
            //ss.ProjectId = 5;
            //ss.ProjectName = "sdsds";
            

            //string Obj = JsonConvert.SerializeObject(ss);

            //string replay = myclient.UploadString("http://localhost:8258/Magic.svc/UpdateEmployee", "PUT", Obj);
            //TextBox1.Text = replay;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //string i = 11.ToString();
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://localhost:8258/Magic.svc/DeleteEmployee/");
            //client.DefaultRequestHeaders.Accept.Clear();
            //HttpResponseMessage response = client.DeleteAsync(i).Result;

        }
    }

    public class EmpInfo
    {
        public int EmpId { get; set; }
       
        public string EmpName { get; set; }
        
        public decimal EmpSalary { get; set; }
    
        public string EmpAddress { get; set; }
      
        public int ProjectId { get; set; }
       
        public string ProjectName { get; set; }
    }

}