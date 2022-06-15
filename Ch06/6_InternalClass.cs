using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜: 2022/06/14
 * 이름: 박성진
 * 내용: 자주 사용하는 내장 클래스 실습
 */
namespace Ch06
{
    internal class _6_InternalClass
    {
        static void Main(string[] args)
        {
            //Math 클래스
            Console.WriteLine($"PI: {Math.PI}");
            Console.WriteLine($"9의 제곱근: {Math.Sqrt(9)}");
            Console.WriteLine($"9의 제곱근: {Math.Sqrt(16)}");
            Console.WriteLine($"절댓값: {Math.Abs(-5)}");
            Console.WriteLine($"올림: {Math.Ceiling(1.2)}");
            Console.WriteLine($"올림: {Math.Ceiling(1.9)}");
            Console.WriteLine($"내림: {Math.Floor(1.2)}");
            Console.WriteLine($"내림: {Math.Floor(1.9)}");
            Console.WriteLine($"반올림: {Math.Round(1.2)}");
            Console.WriteLine($"반올림: {Math.Round(1.9)}");
            Console.WriteLine();

            //Random 클래스
            Random random = new Random();
            int rand1 = random.Next();
            Console.WriteLine($"rand1: {rand1}");

            int rand2 = random.Next(10); //0에서 9사이의 임의의 정수
            Console.WriteLine($"rand2: {rand2}");

            int rand3 = random.Next(-10, 10); //-10에서 9사이의 임의의 정수
            Console.WriteLine($"rand3: {rand3}");

            double rand4 = random.NextDouble(); //0에서 1사이의 임의의 실수
            Console.WriteLine($"rand4: {rand4}");

            double rand5 = rand4 * 10;
            Console.WriteLine($"rand5: {rand5}");

            double rand6 = Math.Ceiling(rand5);
            Console.WriteLine($"rand6: {rand6}");

            //DateTime 클래스
            //싱글톤 객체
            DateTime now = DateTime.Now;
            Console.WriteLine($"Now: {now}");

            //개별 시간 데이터 출력
            Console.WriteLine($"년: {now.Year}");
            Console.WriteLine($"월: {now.Month}");
            Console.WriteLine($"일: {now.Day}");
            Console.WriteLine($"시: {now.Hour}");
            Console.WriteLine($"분: {now.Minute}");
            Console.WriteLine($"초: {now.Second}");

            //문자열 format
            string result1 = now.ToString("yyyy-mm-dd");
            Console.WriteLine($"result1: {result1}");

            string result2 = now.ToString("yy-MM-dd hh:mm:ss");
            Console.WriteLine($"result2: {result2}");

        }
    }
}
