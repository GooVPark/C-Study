using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜: 2022/06/10
 * 이름: 박성진
 * 내용: 최대공약수 연습문제
 */
namespace Test.Sub02
{
    internal class _2_07
    {
        static void Main7(string[] args)
        {
            Console.WriteLine("  1과   5의 최대 공약수 : " + Gcd(1, 5));
            Console.WriteLine("  3과   6의 최대 공약수 : " + Gcd(3, 6));
            Console.WriteLine(" 12과  18의 최대 공약수 : " + Gcd(12, 18));
            Console.WriteLine(" 60과  24의 최대 공약수 : " + Gcd(60, 24));
            Console.WriteLine("192과 162의 최대 공약수 : " + Gcd(192, 162));
        }

        public static int Gcd(int a, int b)
        {
            int temp;
            if (a < b) temp = a;
            else temp = b;

            while (true)
            {
                if(a % temp == 0 && b % temp == 0)
                {
                    return temp;
                }

                temp--;
            }

            return temp;
        }
    }
}
