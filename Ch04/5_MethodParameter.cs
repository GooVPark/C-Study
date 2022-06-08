using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/06/07
 * 이름: 박성진
 * 내용: 매서드 출력전용 매개변수
 * 
 * 출력 매개변수 ref
 * -변수의 reference값으로 참조값이 가리키는 실제 변수에 값을 대입하는 매개변수
 * 
 * 출력 매개변수 out
 * -별도의 변수선언 없이 바로 매서드 호출시 매서드의 결과를 리턴받는 매개변수
 * -매서드는 하나의 리턴값을 여러개 값을 리턴할 수 있는 효과를 얻는다.
 */

namespace Ch04
{
    internal class _5_MethodParameter
    {
        static void Main5(string[] args)
        {
            //ref 매개변수
            int num1 = 10;
            int num2 = 3;
            int num3 = 0;
            int num4 = 0;

            DividerRef(num1, num2, ref num3, ref num4);
            Console.WriteLine($"몫: {num3}, 나머지: {num4}");
            //out 매개변수
        }

        public static void DividerRef(int a, int b, ref int quotient, ref int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        public static void DividerOut(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
    }
}
