using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03
{
    /*
     * 날짜: 2022/06/07
     * 이름: 박성진
     * 내용: 반복문 실습하기 교재 p157
     */
    internal class _3_For
    {
        static void Main3(string[] args)
        {
            //for문
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{i}회 반복");
            }

            //1부터 10까지의 합
            int sum1 = 0;
            for(int i = 1; i <= 10; i++)
            {
                sum1 += i;
            }

            Console.WriteLine($"1부터 10까지 정수의 합: {sum1}");

            //1부터 10까지 짝수의 합
            int sum2 = 0;
            for(int i = 2; i <= 10; i += 2)
            {
                sum2 += i;
            }

            Console.WriteLine($"1부터 10까지 짝수의 합: {sum2}");

            //중첩 for문
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 5; k++)
                    {
                        Console.WriteLine($"k: {k}");
                    }
                }
            }
            //구구단
            for(int i = 1; i <= 9; i++)
            {
                for(int j = 2; j <= 9; j++)
                {
                    Console.Write($" {j} X {i} = {i * j} ".PadRight(15));
                }
                Console.WriteLine("\n");
            }
            
            //별삼각형
            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 10 - i; j++)
                {
                    Console.Write("★");
                }
                Console.WriteLine();
            }

        }
    }
}
