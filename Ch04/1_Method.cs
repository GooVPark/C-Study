using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04
{
    /*
     * 날짜: 2022/06/07
     * 이름: 박성진
     * 내용: 메서드 실습하기 교재 p265
     */
    internal class _1_Method
    {
        static void Main1(string[] args)
        {
            int t1 = Func2(1, 10);
            int t2 = Func2(1, 100);
            int t3 = Func2(start: 1, end: 1000);

            Console.WriteLine($"t1: {t1}");
            Console.WriteLine($"t2: {t2}");
            Console.WriteLine($"t3: {t3}");
        }

        public static int f(int x)
        {
            int y = 2 * x + 3;
            return y;
        }

        public static int Func2(int start, int end)
        {
            int total = 0;

            for(int i = start; i <= end; i++)
            {
                total += i;
            }

            return total;
        }
    }
}
