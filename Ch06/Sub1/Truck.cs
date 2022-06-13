using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{
    internal class Truck : Car
    {
        private int capasity;

        public Truck(string name, string color, int speed, int capasity) : base(name, color, speed)
        {
            this.capasity = capasity;
        }

        public override void SpeedUp(int speed)
        {
            Console.WriteLine("Truck Speed Up");
            base.speed += speed;
        }
        public override void SpeedDown(int speed)
        {
            Console.WriteLine("Truck Speed Down");
            base.speed -= speed;
        }

        public override void Show()
        {
            Console.WriteLine("==============");
            Console.WriteLine("차량명: " + name);
            Console.WriteLine("차량색: " + color);
            Console.WriteLine("차량 속도: " + speed);
            Console.WriteLine("적재량: " + capasity);
        }
    }
}
