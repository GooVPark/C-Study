using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub2
{
    internal class Car
    {
        public Car(string name, string color, int speed)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
        }

        //속성
        private string name;
        public string Name { get { return name; } set { name = value; } }
        private string color;
        public string Color { get { return color; } set { color = value; } }
        private int speed;
        public int Speed 
        {
            get
            {
                return speed;
            }
            set
            {
                if (value < 0) speed = 0;
                else speed = value;
            }
        }
        //기능

        public void SpeedUp(int speed)
        {
            this.speed += speed;
        }

        public void SpeedDown(int speed)
        {
            this.speed -= speed;
        }

        public void Show()
        {
            Console.WriteLine("==============");
            Console.WriteLine("차량명: " + name);
            Console.WriteLine("차량색: " + color);
            Console.WriteLine("차량 속도: " + speed);
        }
    }
}
