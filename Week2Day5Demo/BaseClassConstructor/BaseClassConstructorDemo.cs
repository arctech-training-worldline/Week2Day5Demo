using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5Demo.BaseClassConstructor
{
    public class Employee
    {
        private string _name;

        public Employee()
        {
            _name = "";
        }

        // Overloaded parameterized constructor
        public Employee(string name)
        {
            _name = name;
        }

        public virtual string GetData()
        {
            return $"Employee name = {_name}";
        }
    }

    public class EmployeeV2 : Employee
    {
        public int _id;
        public int _age;
        public double _salary;

        public EmployeeV2(string name, int id, int age, double salary) : base(name)
        {
            _id = id;
            _age = age;
            _salary = salary;
        }

        public override string GetData()
        {
            return $"{base.GetData()}, id = {_id}, age = {_age}, salary = {_salary}";
        }
    }

    internal class BaseClassConstructorDemo
    {
        public static void Test()
        {
            //Employee b1 = new Employee();
            //Employee b2 = new Employee("Test");

            //Console.WriteLine(b1.GetData());
            //Console.WriteLine(b2.Show());

            EmployeeV2 b1 = new EmployeeV2("Test", 101, 22, 10000);
            //EmployeeV2 b2 = new EmployeeV2("Test");

            Console.WriteLine(b1.GetData());
            //Console.WriteLine(b2.Show());
        }
    }
}
