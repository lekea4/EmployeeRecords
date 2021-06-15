using EmployeeRecords;
using System;
using System.Text;
using System.Collections;

namespace EmployeeRecords
{
    class Program
    {
        static void Main(string[] args)
        {


            var employee1 = new Employee("John Doe","20-05-2020","Accountant", "Finance");

           // Console.WriteLine($"A new employee with records Name: {employee1.Name}, staff ID: {employee1.StaffId}, " +
               // $"Employment Date: {employee1.EmploymentDate}, Job Title: {employee1.JobTitle}, Department: {employee1.Department} ");
              

            var employee2 = new Employee("Janet Jackson", "25-05-2020", "Dancer", "Creatives");
            //Console.WriteLine($"A new employee with records Name: {employee2.Name}, staff ID: {employee2.StaffId}, " +
               // $"Employment Date: {employee2.EmploymentDate}, Job Title: {employee2.JobTitle}, Department: {employee2.Department}");

            var employee3 = new Employee("Temiloluwa", "20-05-2020", "Stripper", "Creatives");
            //Console.WriteLine($"A new employee with records Name: {employee3.Name}, staff ID: {employee3.StaffId}, " +
                //$"Employment Date: {employee3.EmploymentDate}, Job Title: {employee3.JobTitle}, Department: {employee3.Department}");

            var employee4 = new Employee("Bayowa Odometa", "05-06-2020", "Adviser", "Finance");
            //Console.WriteLine($"A new employee with records Name: {employee4.Name}, staff ID: {employee4.StaffId}, " +
              //  $"Employment Date: {employee4.EmploymentDate}, Job Title: {employee4.JobTitle}, Department: {employee4.Department}");

            var employee5 = new Employee("Hope Ndudim", "10-06-2020", "Anchor", "Creatives");
            //Console.WriteLine($"A new employee with records Name: {employee5.Name}, staff ID: {employee5.StaffId}, " +
            //  $"Employment Date: {employee5.EmploymentDate}, Job Title: {employee5.JobTitle}, Department: {employee5.Department}");

            Employee[] Employee = new Employee [5] { employee1, employee2, employee3, employee4, employee5 };

            Console.WriteLine($"StaffID\t\tName\t\t\tEmployment Date\t\tJob Title\tDepartment");
            foreach (Employee i  in Employee)
            {
                Console.WriteLine(i.StaffId + "\t\t" + i.Name +
                    "\t\t" + i.EmploymentDate + "\t\t" + i.JobTitle + "\t\t" + i.Department);
            }
           
            //Console.WriteLine($"{Employee}\t\t{employee1.Name}\t{employee1.EmploymentDate}\t\t{employee1.JobTitle}\t\t{employee1.Department}");

            // var employeeData = new StringBuilder();

            //header
            //employeeData.AppendLine("StaffID\t\tName\t\tEmployment Date\t\tJob Title\t\tDepartment");
            //foreach (var Employee in employees )
            // {
            //  employeeData.AppendLine($"{Employee.id}\t{employees.}");
            // }

            //return employeeData.ToString();


        }










    }
}
