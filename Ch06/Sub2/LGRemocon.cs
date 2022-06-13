using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal class LGRemocon : IRemoteControl
    {
        public void ChannelDown()
        {
            Console.WriteLine("LG Channel Donw");
        }

        public void ChannelUp()
        {
            Console.WriteLine("LG Channel Up");
        }

        public void PowerOff()
        {
            Console.WriteLine("LG Power Off");
        }

        public void PowerOn()
        {
            Console.WriteLine("LG Power On");
        }

        public void SoundDown()
        {
            Console.WriteLine("LG Sound Down");
        }

        public void SoundUp()
        {
            Console.WriteLine("LG Sound Up");
        }
    }
}
