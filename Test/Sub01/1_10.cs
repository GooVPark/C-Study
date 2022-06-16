﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜: 2022/06/09
 * 이름: 박성진
 * 내용: 피보나치 수열 연습문제
 */


namespace Test.Sub01
{
    internal class _1_10
    {
        static void Main10(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int n3;

            Console.Write(n1 + ", ");
            Console.Write(n2 + ", ");

            for(int i = 1; i <= 10; i++)
            {
                n3 = n1 + n2;

                Console.Write(n3 + ", ");

                n1 = n2;
                n2 = n3;
            }
        }
    }
}
