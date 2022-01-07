using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5Demo
{
    internal class DynamicParameterDemo
    {
        internal static void Test()
        {
            Console.WriteLine(Multiply(10, 20));
            Console.WriteLine(Multiply(10.50f, 20.242f));
            Console.WriteLine(Multiply(10, 20.242f));
            Console.WriteLine(Multiply("Hello", "World"));  // Run-time error
        }

        static dynamic Multiply(dynamic num1, dynamic num2)
        {
            return num1 * num2;
        }
    }
}
