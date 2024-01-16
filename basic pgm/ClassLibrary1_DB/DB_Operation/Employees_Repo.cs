using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_Model;

namespace ClassLibrary1_DB.DB_Operation
{
    public class Employees_Repo
    {
        public int AddEmployee(Employee model)
        {
            using(var context = new EmployeeDBEntities())
            {
                Employee emp = new Employee()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Code = model.Code,

                };
                context.Employee.Add(emp); 
                context.SaveChanges();
                 return emp.Id;
            }

        }


    }
}
