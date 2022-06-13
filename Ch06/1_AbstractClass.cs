using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch06.Sub1;
/*
 * 날짜: 2022/06/13
 * 이름: 박성진
 * 내용: 추상 클래스 실습하기 교재
 * 
 * 추상 클래스(Abstract Class)
 * -공통의 기능은 하나의 메서드로 구현하고 개별적인 기능은 상속 받아 override 메서드로 구현시키는 추상메서드를 갖는 클래스
 * -오직 상속을 목적으로 설계되는 클래스
 */
namespace Ch06
{
    internal class _1_AbstractClass
    {
        static void Main1(string[] args)
        {
            Car sedan = new Sedan("그랜저", "검정색", 0, 2000);
            Car truck = new Truck("포터", "파란색", 0, 1);

            sedan.SpeedUp(10);
            sedan.SpeedDown(5);
            sedan.Show();

            truck.SpeedUp(10);
            truck.SpeedDown(5);
            truck.Show();
        }
    }
}
