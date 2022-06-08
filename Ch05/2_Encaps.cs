using Ch05.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/06/08
 * 이름: 박성진
 * 내용: 캡슐화 실습하기 교재 p203
 */
namespace Ch05
{
    internal class _2_Encaps
    {
        static void Main2(string[] args)
        {
            Account kb = new Account("kb", "13141", "AAA", 13450);

            kb.Deposit(10000);
            kb.Withdraw(10000);
            kb.Show();

            Car sonata = new Car("소나타", "흰색", 50);

            sonata.Name = "EF소나타";
            sonata.Speed = -100;

            Console.WriteLine("sonata 객체 name: " + sonata.Name);
        }
    }
}
