using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/06/10
 * 이름: 박성진
 * 내용: 배열 연습문제
*/

namespace Test.Sub02
{
    internal class _2_01
    {
        static void Main1(string[] args)
        {
            char[] str = { 'I', ' ', 'L', 'O', 'V', 'E', ' ', 'Y', 'O', 'U' };
            int row, col;

            for (row = 1; row < 10; row++)
            {
                for (col = 0; col <= row; col++)
                {
                    Console.Write(str[col]);
                }
                Console.Write('\n');
            }
        }
    }
}
