using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5Demo.GetterSetterDemo
{
    class EmployeeWithShortcutProperties
    {
        private int _id;
        private string _name;

        public EmployeeWithShortcutProperties(int id, string name)
        {
            _id = id;
            _name = name;
        }

        // C# property - New way of writing getter and setter.
        // readwrite property
        public string Name
        {
            get => _name;

            set
            {
                if (_name.Length <= 2 || _name.Length > 100)
                    Console.WriteLine("Name is too large");
                else
                    _name = value;
            }
        }

        // readonly property
        public int Id => _id;
    }

    internal class GetterSetterShortcutExamples
    {
        public static void Test()
        {
            EmployeeWithShortcutProperties emp = new EmployeeWithShortcutProperties(101, "Raman");

            Console.WriteLine(emp.Id);
            Console.WriteLine(emp.Name);
            emp.Name = "Gia";
            Console.WriteLine(emp.Name);
        }
    }
}
