using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02
{
    internal class _5_Conversion
    {
        /*
         * 날짜: 2022/06/03
         * 이름: 박성진
         * 내용: 데이터 형식 변환 실습 교재 p106
         */
        static void Main5(string[] args)
        {
            //작은 변수에서 큰 변수
            byte num1 = 255;
            short num2 = num1;
            int num3 = num2;

            Console.WriteLine($"num1: {num1}");
            Console.WriteLine($"num2: {num2}");
            Console.WriteLine($"num3: {num3}");

            //큰 변수에서 작은 변수
            int num4 = 256;
            short num5 = (short)num4;
            byte num6 = (byte)num5;

            Console.WriteLine($"num4: {num4}");
            Console.WriteLine($"num5: {num5}");
            Console.WriteLine($"num6: {num6}");

            //정수에서 실수
            int num7 = 1;
            int num8 = 2;
            int num9 = 3;

            double num10 = num7;
            double num11 = num8;
            double num12 = num9;

            Console.WriteLine($"num10: {num10}");
            Console.WriteLine($"num11: {num11}");
            Console.WriteLine($"num12: {num12}");

            //실수에서 정수
            double num13 = 1.2;
            double num14 = 2.15;
            double num15 = 11.234;

            int num16 = (int)num13;
            int num17 = (int)num14;
            int num18 = (int)num15;

            Console.WriteLine($"num16: {num16}");
            Console.WriteLine($"num17: {num17}");
            Console.WriteLine($"num18: {num18}");
        }
    }
}
