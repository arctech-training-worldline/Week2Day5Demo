using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5Demo
{
    class Student
    {
        public string name;

        public string GetData()
        {
            return $"name={name}";
        }
    }

    internal class WithoutRefParamsDemo
    {
        /// <summary>
        /// Value variables on stack
        /// </summary>
        public static void Test2()
        {
            int i = 10;

            ProcessNumber(i);
            Console.WriteLine($"1. {i}");
        }

        private static void ProcessNumber(int j)
        {
            j = 20;
            Console.WriteLine($"2. {j}");
        }

        /// <summary>
        /// Reference variables on heap
        /// </summary>
        public static void Test1()
        {
            Student s = new Student { name = "Raman" };

            ProcessStudent(s);
            Console.WriteLine($"1. {s.GetData()}");       // Raman Gujral
        }

        private static void ProcessStudent(Student s)
        {
            s.name = "Raman Gujral";
            s = new Student { name = "Tejal Goswami" };

            Console.WriteLine($"2. {s.GetData()}");       // Tejal Goswami
        }
    }
}
