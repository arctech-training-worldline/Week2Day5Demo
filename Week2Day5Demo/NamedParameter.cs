using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5Demo
{
    internal class NamedParameter
    {
        public static void TestNamedParams()
        {
            int ans = Sum(z: 30, y: 20, x: 10);
            Console.WriteLine(ans);

            Show("Hello", 10);
            Show("Shubham", 22);

            Show(age: 25, firstName: "Raman");
        }

        static void Show(string firstName, int age)
        {
            Console.WriteLine($"s={firstName}, y={age}");
        }

        static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
    }
}
