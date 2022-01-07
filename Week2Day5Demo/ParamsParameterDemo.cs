using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5Demo
{
    internal class ParamsParameterDemo
    {
        internal static void Test()
        {
            Console.WriteLine(Add(10));
            Console.WriteLine(Add(10, 20));
            Console.WriteLine(Add(10, 20, 30));
            Console.WriteLine(Add(10, 20, 30, 40));
            Console.WriteLine(Add(10, 20, 30, 40, 50, 60, 70));
        }

        static long Add(params int[] data)
        {
            int total = 0;
            foreach (int num in data)
            {
                total += num;
            }

            return total;
        }
    }
}
