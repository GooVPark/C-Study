﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/06/09
 * 이름: 박성진
 * 내용: 연산자 연습문제
 */

namespace Test.Sub01
{
    internal class _1_03
    {
        static void Main03(string[] args)
        {
            int x = 4;
            int y = -2;
            int z = 0;

            z = x + y;
            Console.WriteLine("x + y = " + z);

            z = x - y;
            Console.WriteLine("x - y = " + z);

            z = x * y;
            Console.WriteLine("x * y = " + z);

            z = x / y;
            Console.WriteLine("x / y = " + z);

            z = (x + y) * (x - y);
            Console.WriteLine("(x + y) * (x - y) = " + z);
        }
    }
}
