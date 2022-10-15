using System;

namespace AbstractionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //The Program class is dependent on a implementation (Class)

            //The Problem is tight coupling 

            // To Use Abstractions. -2 ways are used for managing the abstractions 1. By using abstract classes 2. BY using the interfaces.

            EmployeeAbstract repo = new EmployeeRepository();
            repo.AddNewEmployee(new Employee());
            repo.UpdateEmployee(new Employee());
            repo.DeleteEmployee(0);
        }
    }
}
