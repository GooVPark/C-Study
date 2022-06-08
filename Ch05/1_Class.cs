using Ch05.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/06/08
 * 이름: 박성진
 * 내용: 클래스와 객체 실습하기 교재 p203
 * 
 * 클래스와 객체
 * -클래스는 
 */
namespace Ch05
{
    internal class _1_Class
    {
        static void Main11(string[] args)
        {
            Car sonata = new Car();
            sonata.name = "소나타";
            sonata.color = "흰색";
            sonata.speed = 0;
            sonata.SpeedUp(10);
            sonata.SpeedUp(50);
            sonata.SpeedDown(20);
            sonata.Show();


            Account kb = new Account();
            kb.bank = "국민은행";
            kb.id = "101-23-11-2";
            kb.name = "이이름";
            kb.balance = 1000000;

            kb.Deposit(10000);
            kb.Withdraw(10000);
            kb.Show();
        }
    }
}
