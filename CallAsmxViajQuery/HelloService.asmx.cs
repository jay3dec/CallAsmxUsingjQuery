using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Serialization;
using System.Web.Script.Services;

namespace CallAsmxViajQuery
{
    /// <summary>
    /// Summary description for HelloService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [ScriptService]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class HelloService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        
        [WebMethod]
        public Employee GetEmployeeDetail()
        {
            Employee objEmp = new Employee();
            objEmp.EmpFirstName = "Tech";
            objEmp.EmpLastName = "Illumination";
            return objEmp;
        }
    }

    public class Employee
    {
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
    }
}
