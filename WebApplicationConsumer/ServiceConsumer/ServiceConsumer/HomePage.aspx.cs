using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace ServiceConsumer
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //WebClient MyClient = new WebClient();
            //string Array = MyClient.DownloadString("http://localhost:8258/Magic.svc/Employees");
            //TextBox1.Text = Array;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            // myclient.Headers.Add("Content-Type", "text");
            // myclient.Encoding = Encoding.UTF8;

            WebClient myclient = new WebClient();
            myclient.Headers[HttpRequestHeader.ContentType] = "application/json";
            EmpInfo ss = new EmpInfo();
            ss.EmpId = 3;
            ss.EmpName = "asasa";
            ss.EmpSalary = 20555;
            ss.EmpAddress = "asasasas";
            ss.ProjectName = "sdsds";
            ss.ProjectId = 5;

        string Obj = JsonConvert.SerializeObject(ss);
        
        string replay = myclient.UploadString("http://localhost:8258/Magic.svc/InsertEmployee", "POST", Obj);
        TextBox1.Text = replay;
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