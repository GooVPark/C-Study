using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal class SamsungRemocon : IRemoteControl
    {
        public void ChannelDown()
        {
            Console.WriteLine("Samsung Channel Down");
        }

        public void ChannelUp()
        {
            Console.WriteLine("Samsung Channel Up");
        }

        public void PowerOff()
        {
            Console.WriteLine("Samsung power Off");
        }

        public void PowerOn()
        {
            Console.WriteLine("Samsung Power On");
        }

        public void SoundDown()
        {
            Console.WriteLine("Samsung Sound Down");
        }

        public void SoundUp()
        {
            Console.WriteLine("Samsung Sound Up");
        }
    }
}
