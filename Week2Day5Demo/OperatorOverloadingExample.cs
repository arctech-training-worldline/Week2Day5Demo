using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5Demo
{
    class Size
    {
        public int width;
        public int height;

        public Size(int w, int h)
        {
            width = w;
            height = h;
        }

        public static Size operator + (Size s1, Size s)
        {
            return new Size(s1.width + s.width, s1.height + s.width);
        }

        public static Size operator -(Size s1, Size s)
        {
            return new Size(s1.width - s.width, s1.height - s.width);
        }

        public static Size operator /(Size s1, int factor)
        {
            return new Size(s1.width / factor, s1.height / factor);
        }


        
        public Size Add(Size s)
        {
            return new Size(width + s.width, height + s.width);
        }

        public Size Substract(Size s)
        {
            return new Size(width - s.width, height - s.width);
        }

        public Size Divide(int factor)
        {
            return new Size(width / factor, height / factor);
        }
        

        public string GetData()
        {
            return $"width: {width} height: {height}";
        }
    }

    internal class OperatorOverloadingExample
    {
        public static void Test()
        {
            Size s1 = new Size(10, 20);
            Size s2 = new Size(100, 200);
            Size s3 = new Size(1000, 2000);

            Size s4 = ((s1 + s2) - (s1 + s3)) / 2;                  // very readable and intutive
            Size s5 = s1.Add(s2).Substract(s1.Add(s3)).Divide(2);   // not very intutive not readable

            Console.WriteLine(s4.GetData());
            Console.WriteLine(s5.GetData());
        }
    }
}
