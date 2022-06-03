using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/06/02
 * 이름: 박성진
 * 내용: 조건문 실습 교재 p127
 */

namespace Ch03
{
    internal class _1_If
    {
        static void Main1(string[] args)
        {
            //if
            int num1 = 1;
            int num2 = 2;

            if(num1 < num2)
            {
                Console.WriteLine("num1은 num2보다 작다");
            }
            if (num1 > num2)
            {
                Console.WriteLine("num1은 num2보다 크다");
            }

            if(num1 > 0)
            {
                if(num2 > 1)
                {
                    Console.WriteLine("num1은 0보다 크고, num2는 1보다 크다");
                }
            }

            if(num1 > 0 && num2 > 1)
            {
                Console.WriteLine("num1은 0보다 크고, num2는 1보다 크다");
            }


            //if - else
            if(num1 > num2)
            {
                Console.WriteLine("num1은 num2보다 크다");
            }
            else
            {
                Console.WriteLine("num1은 num2보다 작다");
            }

            //if - else if - else
            int num3 = 10;
            int num4 = 20;
            int num5 = 30;
            int num6 = 40;

            if(num3 > num4)
            {
                Console.WriteLine("num3가 num4보다 크다");
            }
            else if(num4 > num5)
            {
                Console.WriteLine("num4가 num5보다 크다");
            }
            else if(num5 > num6)
            {
                Console.WriteLine("num5가 num6보다 크다");
            }
            else
            {
                Console.WriteLine("num6가 가장 크다");
            }
        }
    }
}
