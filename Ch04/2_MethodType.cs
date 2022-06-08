using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04
{
    internal class _2_MethodType
    {
        static void Main2(string[] args)
        {
            double y1 = Type1(0.1);
            double y2 = Type1(1.2);

            Console.WriteLine("y1: " + y1);
            Console.WriteLine("y2: " + y2);
        }

        public static double Type1(double x)
        {
            double y = x + 3.14;
            return y;
        }

        public static void Type2(bool state)
        {
            if(state)
            {
                Console.WriteLine("참");
            }
            else
            {
                Console.WriteLine("거짓");
            }
        }

        public static string Type3()
        {
            int n1 = 1, n2 = 2;

            if (n1 > n2) return "n1은 n2보다 크다.";
            else return "n1은 n2보다 크지않다.";
        }

        public static void Type4()
        {
            double result = Type1(1.22);
            Console.WriteLine($"Type4 result: {result}");
        }
    }
}
