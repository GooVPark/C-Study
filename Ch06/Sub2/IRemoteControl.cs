using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal interface IRemoteControl
    {
        public abstract void PowerOn();
        public abstract void PowerOff();

        public abstract void ChannelUp();
        public abstract void ChannelDown();

        public abstract void SoundUp();
        public abstract void SoundDown();
    }
}
