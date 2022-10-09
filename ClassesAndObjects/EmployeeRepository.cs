using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class EmployeeRepository
    {
        static Employee[] employees = new Employee[3];

        public EmployeeRepository()//Constructor - Special method , which has the same name as the class and doesnt contain a return type
        {
            //employees[0] =
            //new Employee(1, "Kishore", "kumar", "kk@cloudkampus.com", 784512);
         }

        public void PrintDetails()//Method
        {
           
                foreach (Employee employee in employees)
                {

                    if (employee != null)
                    {
                        Console.WriteLine($"Welcome {employee.EmployeeName}, Contact Details {employee.Email}");
                    }
                    else
                    {

                       
                    }

                
            }
        }

        public void AddNewEmployee()//Method
        {

            //Using the properties for getting the Employee Data
            Employee emp = new Employee();
            emp.EmployeeId = 123;
            emp.EmployeeName = "Kishore Kumar";
            emp.Email = "KK@cloudkampus.com";
            emp.Mobile = 90876543;

            employees[0] = emp;
            PrintDetails();




         //   Console.WriteLine("Enter Employee Id");
         ////   Employee emp = new Employee(100,"Aabha","Kumar","Aabha@gmail.com",784512);
           
         ///   employees[0] = emp;
         //   Console.WriteLine("Employee Details Added ");
         //   PrintDetails();
         //   Employee emp1 = new Employee();
         //   employees[1] = emp1;
         //   PrintDetails();
         //   Employee emp2 = new Employee(102, "Twinkle", "Rajan");
         //   employees[2]=emp2;
         //   PrintDetails();

        }
    }
}
