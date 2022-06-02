using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/06/02
 * 이름: 박성진
 * 내용: C# 개발환경 설정 및 Hello World 출력 교재 p44
 */
namespace Ch01
{
    internal class CH1_HelloWorld
    {
        static void Main(string[] args)
        {
            //기본 출력
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello C#!");

            //서식 출력
            Console.Write("Hello\t"); //\t: tab
            Console.Write("Korea\n"); //\n: 개행

            //포맷 출력
            Console.WriteLine("{0} {1}", "Hello", "Busan");
        }
    }

}
