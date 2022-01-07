using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5Demo
{
    internal class DefaultParameterDemo
    {
        internal static void Test()
        {
            GetData("Sales", "Programmer");
            GetData("Sales", "Salesman");
            GetData("HR", "Candidate");
            GetData("HR");
            GetData("Sales");

            FindEmployeeDepartment("dept1", "101", age: 50);
        }

        /*
        // Function OverLoading.
        // In this scenario in the olden day before default arguments was introduced to C#
        // Only way to implement polymorphism was using function overloading.
        // Now we can use default argument, in some specific cases like this examples
        // to reduce the lines of code need to be written
        static void GetData(string department, string role)
        {
            Console.WriteLine($"Department: {department}, Role={role}");
        }

        static void GetData(string department)
        {
            Console.WriteLine($"Department: {department}, Role=Admin");
        }
        */

        static void GetData(string department, string role = "Admin")
        {
            Console.WriteLine($"Department: {department}, Role={role}");
        }

        static void FindEmployeeDepartment(string department, string employeeCode, string role = "Admin", int age = 20)
        {
            Console.WriteLine($"Department: {department}, EmployeeCode={employeeCode}, Role={role}, Age={age}");
        }
    }
}
