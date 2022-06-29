using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜: 2022/06/28
 * 이름: 박성진
 * 내용: [총정리 문제] 윤년 판별하기
 * 
 * 윤년
 *  - 2월 29일이 추가되어 1년이 366일인 해
 *  - 4로 나누어지고 100으로 나누어지지 않거나 400으로 나누어지는 연도
 */
namespace Test.Sub08
{
    internal class _2_01
    {
        static void Main1(string[] args)
        {
            Console.Write("연도 입력: ");
            int year = int.Parse(Console.ReadLine());

            if(year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine("{0}는 윤년 입니다", year);
            }
            else
            {
                Console.WriteLine("{0}는 평년 입니다.", year);
            }

            if(DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0}는 윤년 입니다", year);
            }
            else
            {
                Console.WriteLine("{0}는 평년 입니다.", year);
            }
        }
    }
}
