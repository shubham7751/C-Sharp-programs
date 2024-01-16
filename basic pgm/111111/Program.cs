using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClassImplementationEx
{
    class Emp
    {
        private int EmpID;
        private string EmpName;
        private string DeptName;
        private double Salary;
        public void addEmp(int id, string en, string dn, double sal)
        {
            this.EmpID = id;
            this.EmpName = en;
            this.DeptName = dn;
            this.Salary = sal;
        }
        public void dispEmp()
        {
            Console.WriteLine("Emp ID:" + this.EmpID);
            Console.WriteLine("Emp Name:" + this.EmpName);
            Console.WriteLine("Dept Name:" + this.DeptName);
            Console.WriteLine("Salary :" + this.Salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            e.addEmp(1, "Ravi", "Computer", 13000);
            e.dispEmp();



            Emp e1 = new Emp();
            e1.addEmp(2, "Ramesh", "Sales", 15000);
            e1.dispEmp();
            Console.ReadKey();



        }
    }
}