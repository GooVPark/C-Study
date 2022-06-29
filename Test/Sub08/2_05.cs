using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜: 2022/06/28
 * 이름: 박성진
 * 내용: [총정리 문제] 반복문으로 팩토리얼 구하기
 */
namespace Test.Sub08
{
    internal class _2_05
    {
        static void Main5(string[] args)
        {
            Console.Write("순자 입력: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for(int i = 1; i <= n;  i++)
            {
                int fact = 1;
                for(int j = 2; j <= i; j++)
                {
                    fact *= j;
                }
                sum += fact;
                Console.WriteLine("{0,2}! = {1,10:#,#}", i, fact);
            }

            Console.WriteLine("1! + 2! + ... + {0}! = {1:n0}\n", n, sum);
        }
    }
}
