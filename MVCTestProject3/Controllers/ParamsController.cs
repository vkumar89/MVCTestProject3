using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestProject3.Controllers
{
    public class ParamsController : Controller
    {
        public string Index1(int id)
        {
            return "The value of id is: " + id;
        }
        public string Index2(int id = 0)
        {
            return "The value of id is: " + id;
        }
        public string Index3(int? id)
        {
            return "The value of id is: " + id;
        }
        public string Index4(int x)
        {
            return "The value of x is:" + x;
        }
        public string Index5(int? x)
        {
            return "The value of x is:" + x;
        }
        public string Index6(string Id)
        {
            return "The value of id is: " + Id;
        }
        public string Index7(int id, string name)
        {
            return "value of id is :" + id + "\n" + "Value of name is :" + name;
        }
        public string Index8(int? Id, string Name)
        {
            return $"Value of Id is: {Id} and value of Name is: {Name}";
        }
        public string Index9(int Pid, string Pname, double Price)
        {
            return $"Pid: {Pid}; Pname: {Pname}; Price: {Price}";
        }

        public string Index10()
        {
            int Pid = int.Parse(Request.QueryString["Pid"]);
            string Pname = Request.QueryString["Pname"];
            double Price = double.Parse(Request.QueryString["Price"]);
            return $"Pid: {Pid}; Pname: {Pname}; Price: {Price}";
        }

        public string Validate1()
        {
            string Name = Request["Name"];
            string Pwd = Request["Pwd"];
            if (Name == "Raju" && Pwd == "Admin")
                return "Valid User";
            else
                return "Invalid User";
        }
        public string Validate2(string Name, string Pwd)
        {
            if (Name == "Raju" && Pwd == "Admin")
                return "Valid User";
            else
                return "Invalid User";
        }
       [ActionName("sayhello1")]
        public string SayHello()
        {
            return "Hello";
        }
        [ActionName("SayHello2")]
        public string SayHello(string name )
        {
            return "Hello"+name;
        }

       

    }
}