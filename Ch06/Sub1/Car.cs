using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{
    public abstract class Car
    {
        //속성
        protected string name;
        protected string color;
        protected int speed;

        public Car(string name, string color, int speed)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
        }

        //기능

        public abstract void SpeedUp(int speed);
        public abstract void SpeedDown(int speed);
        
        public virtual void Show()
        {
            Console.WriteLine("==============");
            Console.WriteLine("차량명: " + name);
            Console.WriteLine("차량색: " + color);
            Console.WriteLine("차량 속도: " + speed);
        }
    }
}
