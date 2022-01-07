using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5Demo.GetterSetterDemo
{
    class Employee
    {
        private int _id;
        //public string _name;
        private string _name;

        public Employee(int id, string name)
        {
            _id = id;
            _name = name;
        }

        // Old way of writing getter and setter.
        /*
        public int GetId()
        { 
            return _id; 
        }
        
        public string GetName()
        {
            return _name;
        }

        public void SetName(string value)
        {
            if (_name.Length <= 2 || _name.Length > 100)
                Console.WriteLine("Name is too large");
            else
                _name = value;
        }
        */

        // C# property - New way of writing getter and setter.
        // readwrite property
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (_name.Length <= 2 || _name.Length > 100)
                    Console.WriteLine("Name is too large");
                else
                    _name = value;
            }
        }

        // readonly property
        public int Id
        {
            get
            {
                return _id;
            }
        }
    }


    internal class GetterSetterExample
    {
        public static void Test()
        {
            Employee emp = new Employee(101, "Raman");

            Console.WriteLine(emp.Id);
            Console.WriteLine(emp.Name);
            emp.Name = "Gia";
            Console.WriteLine(emp.Name);

            //Console.WriteLine(emp.GetId());
            //Console.WriteLine(emp.GetName());
            //Console.WriteLine(emp._name);

            //emp.SetName("Gia");
            //emp._name = "1";
            //Console.WriteLine(emp.GetName());
            //Console.WriteLine(emp._name);
        }
    }
}
