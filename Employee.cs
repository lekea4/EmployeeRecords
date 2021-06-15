using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRecords
{
    public class Employee
    {


        //properties of employee that can not be updated   
        public string StaffId
        {
            get;
        }
        

        public string Name
        {
            get;
        }

        public string EmploymentDate
        {
            get;
        }

        // properties of employee that can be updated 
        public string JobTitle
        {
            get;

            set;
        }

        public string Department
        {
            get;
            set;

        }

        public static int id = 100;

        //constructor for the employee

        public Employee (string name, string employmentDate, string jobTitle,string department)
        {
            
            this.Name = name;
            this.StaffId = id.ToString();
            id++;
            this.EmploymentDate = employmentDate;
            this.JobTitle = jobTitle;
            this.Department = department;
        }

        //methods for employee's functions 

        public void ClockIn(DateTime time, string note )
        {
            //set time of clock in 
            Console.WriteLine("Employee just clocked in");
        }

        public void ClockOut(DateTime time, string note)
        {
            //set time of clock out 
            Console.WriteLine("Employee just clocked out");
        }

        public void Work (DateTime workHours)
        {
            //set work hours duration
            Console.WriteLine("Employee worked for some hours");
        }
    }
}
