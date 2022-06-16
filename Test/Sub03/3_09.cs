using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜: 2022/06/16
 * 이름: 박성진
 * 내용: 다형성 연습문제
 */
namespace Test.Sub03
{
    abstract class Shape
    {
        public abstract void Draw();
    }

    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("삼각형 그리기..."); ;
        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("원 그리기...");
        }
    }
    internal class _3_09
    {
        static void Main9(string[] args)
        {
            _3_09 instance = new _3_09();

            Shape circle = new Circle();
            Shape triangle = new Triangle();

            instance.Draw(circle);
            instance.Draw(triangle);
        }

        public void Draw(Shape shape)
        {
            shape.Draw();
        }
    }
}
