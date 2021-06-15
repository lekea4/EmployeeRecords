using EmployeeRecords;
using System;
using System.Text;


namespace EmployeeRecords
{
    class Program
    {
        static void Main(string[] args)
        {


            var employee1 = new Employee("John Doe","20-05-2020","Accountant", "Finance");

          

            var employee2 = new Employee("Janet Jackson", "25-05-2020", "Dancer", "Creatives");
           
            var employee3 = new Employee("Temiloluwa", "20-05-2020", "Stripper", "Creatives");
           
            var employee4 = new Employee("Bayowa Odometa", "05-06-2020", "Adviser", "Finance");
           
            var employee5 = new Employee("Hope Ndudim", "10-06-2020", "Anchor", "Creatives");
            
            Employee[] Employee = new Employee [5] { employee1, employee2, employee3, employee4, employee5 };

            Console.WriteLine($"StaffID\t\tName\t\t\tEmployment Date\t\tJob Title\tDepartment");
            foreach (Employee i  in Employee)
            {
                Console.WriteLine(i.StaffId + "\t\t" + i.Name +
                    "\t\t" + i.EmploymentDate + "\t\t" + i.JobTitle + "\t\t" + i.Department);
            }
           
            


        }










    }
}
