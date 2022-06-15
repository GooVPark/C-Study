using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch06.Sub2;
/*
 * 날짜: 2022/06/13
 * 이름: 박성진
 * 내용: 인터페이스 실습 교재 p425
 * 
 * 인터페이스(Interface)
 *  -클래스간의 공통의 통일된 표준 규격을 통해 클래스 구조를 설계하는 문법
 *  -인터페이스를 활용해서 다중 상속을 구현
 *  -인터페이스를 활용해서 객체간의 결합도를 완화하는 효과를 얻는다
 */
namespace Ch06
{
    internal class _2_Interface
    {
        static void Main2(string[] args)
        {
            //인터페이스로 공통 클래스 구조설계
            IRemoteControl lg = new LGRemocon();
            IRemoteControl samsung = new SamsungRemocon();

            lg.PowerOn();
            lg.ChannelUp();
            lg.SoundUp();
            lg.PowerOff();

            samsung.PowerOn();
            samsung.ChannelUp();
            samsung.SoundDown();
            samsung.PowerOff();

            //인터페이스를 활용한 다중 상속
            TV tv = new TV();
            tv.PowerOn();
            tv.Booting();
            tv.AccessInternet();

            //인터페이스를 활용한 결합도 완화
            Bulb bulb = new Bulb();
            ISocket cable = new Cable(bulb);
            
            cable.SwitchOn();
            cable.SwitchOff();
        }
    }
}
