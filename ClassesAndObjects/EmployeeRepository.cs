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

        public EmployeeRepository()
        {
            employees[0] =
            new Employee() { employeeId = 1, firstName = "Kishore", lastName = "kumar", email = "kk@cloudkampus.com", mobile = 784512 };
         }

        public void PrintDetails()
        {
            foreach (Employee employee in employees)
            {
                if (employee!=null)
                {
                    Console.WriteLine($"Welcome, {employee.firstName} , { employee.lastName} ");
                    Console.WriteLine($"Your Contact Details {employee.email} and Contact {employee.mobile}");
                }
                
            }


        }

        public void AddNewEmployee()
        {
            Console.WriteLine("Enter Employee Id");
            Employee emp = new Employee();
            emp.employeeId = int.Parse(Console.ReadLine());
            emp.firstName = Console.ReadLine();
            emp.lastName=Console.ReadLine();
            emp.email = Console.ReadLine();
            emp.mobile=long.Parse(Console.ReadLine());
            employees[1] = emp;
            Console.WriteLine("Employee Details Added ");
            PrintDetails();

        }
    }
}
