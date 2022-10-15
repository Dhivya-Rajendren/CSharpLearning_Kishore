using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{

    //How to 
    internal class EmployeeRepository  :EmployeeAbstract, ISalaryAbstract  // Logic needed for handling the Domain Data 
    {
        // Functionalities

        //Add a New Employee
        // Updating the ex Employee
        //deleteing the employee

        static Employee[] employees = new Employee[3];
        public EmployeeRepository()
        {
            Employee employee = new Employee() { EmployeeId = 1, EmployeeName = "John", Address = "Chennai", Contact = 784512, PersonalEmail = "John@gmail.com", OfficialEmail = "John@cloudkampus.com", IsActive = true };
employees[0]= employee;
        }

        public override void AddNewEmployee(Employee employee)
        {
            employees[1] = employee;
        }

        public override void UpdateEmployee(Employee employee)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i]!=null)
                {
                    var emp = Array.Find(employees, e => e.EmployeeId == employee.EmployeeId);
                    employees[i] = employee;
                }
            }
        }

        public override void DeleteEmployee(int employeeID)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null)
                {
                    var emp = Array.Find(employees, e => e.EmployeeId == employeeID);
                    employees[i] = null;
                }
            }
        }

        public double MakeSalaryPayment(int EmployeeId)
        {
            throw new NotImplementedException();
        }
    }
}
