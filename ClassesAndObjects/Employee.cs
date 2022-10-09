using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Employee
    {


        //auto-implemented properties 
        public int EmployeeAddress { get; set; }



        private int employeeAge;

        public int EAge
        {
            get { return employeeAge; }
            set { employeeAge = value; }
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }





        private int employeeId;

        //Properties 
        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        private string employeeName;

        public string EmployeeName
        {
            get {
                foreach (var item in employeeName)
                {
                    if (char.IsDigit(item))
                    {
                        employeeName = "Invalid Name  containg letters";
                    }
                }


                return employeeName; }
            set {
                
                
                employeeName = value; }
        }

        private string email;

        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        private long mobile;

        public long Mobile
        {
            set { mobile = value; }
            get { return mobile; }
        }
    







        //  //Constructor overloading 

        //  //Constructor version1 
        //  public Employee(int empId, string fName, string lName, string email, long mobile)
        //  {
        //      this.employeeId = empId;
        //      this.firstName = fName;
        //      this.lastName = lName;
        //      this.email = email;
        //      this.mobile = mobile;
        //  }
        //  //Constructor version2
        //  public Employee()
        //  {

        //  }

        //  //Constructor version 3 
        //  public Employee(int empId, string fName, string lName)
        //  {
        //      this.employeeId = empId;
        //      this.firstName = fName;
        //      this.lastName = lName;
        //  }

        //public void PrintDetails()
        //  {
        //      Console.WriteLine($"Welcome {firstName},{lastName}");
        //  }

    }
}
