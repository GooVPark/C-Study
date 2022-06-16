using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/06/09
 * 이름: 박성진
 * 내용: 피라미드 출력 연습문제
 */

namespace Test.Sub01
{
    internal class _1_08
    {
        static void Main08(string[] args)
        {
            int n = 5;

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }

                for(int j = 0; j < i * 2 + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
