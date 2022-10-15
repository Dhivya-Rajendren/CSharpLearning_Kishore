using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{

    //What are 
    internal  abstract class EmployeeAbstract
    {
        public abstract void AddNewEmployee(Employee employee);
        public abstract void UpdateEmployee(Employee employee);
        public abstract void DeleteEmployee(int employeeID);
    }

    interface ISalaryAbstract
    {
        //What are 
        double MakeSalaryPayment(int EmployeeId);
    }
    
}
