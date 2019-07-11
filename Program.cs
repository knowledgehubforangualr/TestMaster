using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
   public class Employee
    {
        public int Id { get; set; }
        public string Ename { get; set; }
        public string LastName { get; set; }
        public string Eadd { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = "rama";
            int i = Convert.ToInt32(s);
            

            List<Employee> lstEmp = new List<Employee>() {
                new Employee{ Id=1,Ename="raja",LastName="Bob",Eadd="Bng"},
                new Employee{ Id=2,Ename="raja2",LastName="john",Eadd="Uk"},
                new Employee{ Id=3,Ename="raja3",LastName="Phill",Eadd="US"}
            };

            Console.WriteLine("Hello World!");
        }
    }
}
