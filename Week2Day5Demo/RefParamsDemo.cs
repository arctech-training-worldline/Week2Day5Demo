using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5Demo
{
    class Employee
    {
        public string name;

        public string GetData()
        {
            return $"name={name}";
        }
    }

    internal class RefParamsDemo
    {
        /// <summary>
        /// Value variables on stack
        /// </summary>
        public static void Test2()
        {
            int i = 10;

            ProcessNumber(ref i);
            Console.WriteLine($"1. {i}");   // 20
        }

        private static void ProcessNumber(ref int j)
        {
            j = 20;
            Console.WriteLine($"2. {j}");   // 20
        }

        /// <summary>
        /// Reference variables on heap
        /// </summary>
        public static void Test1()
        {
            Employee e = new Employee { name = "Raman" };

            ProcessStudent(ref e);
            Console.WriteLine($"1. {e.GetData()}");       // Tejal Goswami
        }

        private static void ProcessStudent(ref Employee emp)
        {
            emp.name = "Raman Gujral";
            emp = new Employee { name = "Tejal Goswami" };

            Console.WriteLine($"2. {emp.GetData()}");       // Tejal Goswami
        }
    }
}
