using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜: 2022/06/16
 * 이름: 박성진
 * 내용: 인터페이스 연습문제
 */
namespace Test.Sub03
{
    interface Buyer
    {
        public abstract void Buy();
    }

    interface Seller
    {
        public abstract void Sell();
    }

    class Customers : Buyer, Seller
    {
        public void Sell()
        {
            Console.WriteLine("판매하기");
        }
        public void Buy()
        {
            Console.WriteLine("구매하기");
        }
    }
    internal class _3_10
    {
        static void Main10(string[] args)
        {
            Buyer buyer = new Customers();
            Seller seller = new Customers();

            buyer.Buy();
            seller.Sell();
        }
    }
}
