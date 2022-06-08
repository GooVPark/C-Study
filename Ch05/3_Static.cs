using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch05.Sub3;

/*
 * 날짜: 2022/06/08
 * 이름: 박성진
 * 내용: 클래스 변수, 클래스 매서드 실습 교재 p225
 * 
 * 클래스 변수(정적변수), 클래스 매서드(정적매서드)
 * -static 변수, Data영역 메모리공간에 하나의 클래스 변수로 관리
 * -클래스 타입(객체 생성 없이)으로 직접참조
 */
namespace Ch05
{
    class Increament
    {
        public Increament()
        {
            Console.WriteLine($"num1: {num1}");
            Console.WriteLine($"num2: {num2}");
        }
        public static int num1;
        public static int num2;

        public static void Add()
        {
            num1++;
            num2++;
        }
    }

    internal class _3_Static
    {
        static void Main(string[] args)
        {
            Increament increament = new Increament();
            Increament.Add();

            Car car1 = new Car("A", "Black", 0);
            Car car3 = new Car("B", "Red", 0);
            Car car2 = new Car("C", "Blue", 0);

            car1.Show();
            car2.Show();
            car3.Show();

            Calc calc = new Calc();
        }

    }
}
