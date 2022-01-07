using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5Demo
{
    internal class OutParamsDemo
    {
        public static void Test()
        {
            float average;
            int count;
            int sum;

            GetArithmeticValues(10, 20, out average, out count, out sum);

            Console.WriteLine($"Average: {average} Count: {count} Sum: {sum}");
        }

        /// <summary>
        /// Create a function which takes 2 parameters
        /// and returns average, count & sum
        /// </summary>
        public static void GetArithmeticValues(int num1, int num2, out float average, out int count, out int sum)
        {
            average = (num1 + num2) / 2;
            Console.WriteLine($"Num1 = {num1}, average={average}");
            count = 2;
            sum = num1 + num2;
        }
    }
}
