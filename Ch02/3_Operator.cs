using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/06/02
 * 이름: 박성진
 * 내용: 연산자(Operator) 실습하기 교재 p90
 * 
 * 연산자(Operator)
 * -변수에 저장된 데이터를 처리하기 위해 연산자를 사용
 * -연산자는 크게 산술, 증가, 감소, 복합대입, 비교, 논리 연산자 등이 있다.
 */

namespace Ch02
{
    internal class _3_Operator
    {
        static void Main3(string[] args)
        {
            //산술 연산자
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;

            int r1 = num1 + num2;
            int r2 = num1 - num2;
            int r3 = num2 * num3;
            int r4 = num4 / num2;
            int r5 = num4 % num3;

            Console.WriteLine("r1: {0}", r1);
            Console.WriteLine("r2: {0}", r2);
            Console.WriteLine("r3: {0}", r3);
            Console.WriteLine("r4: {0}", r4);
            Console.WriteLine("r5: {0}", r5);

            //증감 연산자
            int num5 = 0;
            num5++;
            ++num5;

            Console.WriteLine($"num5: {num5}"); //문자열 보간 출력

            int num6 = 0;
            num6--;
            --num6;

            Console.WriteLine($"num6: {num6}");

            //복합대입 연산자
            int num7 = 1, num8 = 2, num9 = 3, num10 = 4;

            num7 += 1;
            num8 -= 2;
            num9 *= 3;
            num10 /= 4;

            Console.WriteLine($"n1: {num7}");
            Console.WriteLine($"n2: {num8}");
            Console.WriteLine($"n3: {num9}");
            Console.WriteLine($"n4: {num10}");

            //비교 연산자
            int num11 = 1;
            int num12 = 2;

            bool r6 = num11 > num12;
            bool r7 = num11 < num12;
            bool r8 = num11 >= num12;
            bool r9 = num11 <= num12;
            bool r10 = num11 == num12;
            bool r11 = num11 != num12;

            Console.WriteLine($"r6: {r6}");
            Console.WriteLine($"r7: {r7}");
            Console.WriteLine($"r8: {r8}");
            Console.WriteLine($"r9: {r9}");
            Console.WriteLine($"r10: {r10}");
            Console.WriteLine($"r11: {r11}");

            //논리 연산자
            int num13 = 1;
            int num14 = 2;

            bool r12 = num13 > 1 && num14 > 2;
            bool r13 = num13 > 0 && num14 > 1;
            bool r14 = num13 > 1 || num14 > 2;
            bool r15 = num13 > 0 || num14 > 2;
            bool r16 = !(num13 > num14);

            Console.WriteLine($"r12: {r12}");
            Console.WriteLine($"r13: {r13}");
            Console.WriteLine($"r14: {r14}");
            Console.WriteLine($"r15: {r15}");
            Console.WriteLine($"r16: {r16}");

            //조건 연산자
            int num15 = 1;
            string r17 = (num15 > 1) ? "num15는 1보다 크다." : "num15는 1보다 크지 않다.";
        }
    }
    
}
