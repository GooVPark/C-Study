using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Sub07
{
    internal class _1_10
    {
        static void Main10(string[] args)
        {
            string s = "before";
            Console.WriteLine(s);

            Test(s);
            Console.WriteLine(s);

            Test(ref s);
            Console.WriteLine(s);
        }

        public static void Test(string s)
        {
            s = "after";
        }
        public static void Test(ref string s)
        {
            s = "after";
        }
    }
}
