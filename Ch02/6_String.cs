using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/06/02
 * 이름: 박성진
 * 내용: 문자열(string) 처리 실습 교쟈 p112
 */
namespace Ch02
{
    internal class _6_String
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";
            Console.WriteLine($"greeting: {greeting}");
            Console.WriteLine();

            //문자열 길이
            Console.WriteLine($"greeting의 길이: {greeting.Length}");
            Console.WriteLine();

            //문자열 추출
            Console.WriteLine($"greeting[0]: {greeting[0]}");
            Console.WriteLine($"greeting[3]: {greeting[3]}");
            Console.WriteLine($"greeting[5]: {greeting[5]}");
            Console.WriteLine();

            //IndexOf
            //LastIndexOf
            //Substring
            //Replace
        }
    }
}
