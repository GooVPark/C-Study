using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch07.Sub1;
/*
 * 날짜: 2022/06/15
 * 이름: 박성진
 * 내용: 컬렉션 리스트 실습하기
 * 
 * ArrayList
 *  - 배열과 유사한 동적 선형 자료구조
 *  - List는 ArrayList를 일반화 시킨 자료구조
 */
namespace Ch07
{
    internal class _3_ArrayList
    {
        static void Main3(string[] args)
        {
            ArrayList list1 = new ArrayList();

            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);
            ShowObject(list1);

            list1.Insert(1, 6);
            ShowObject(list1);

            list1.Remove(6);
            list1.RemoveAt(0);
            ShowObject(list1);

            ArrayList list2 = new ArrayList();

            list2.Add(100);
            list2.Add(0.1234);
            list2.Add(false);
            list2.Add('A');
            list2.Add("Apple");
            ShowObject(list2);

            List<int> list3 = new List<int>();

            list3.Add(1);
            list3.Add(2);
            list3.Add(3);
            list3.Add(4);
            list3.Add(5);
            ShowObject(list3);

            List<string> list4 = new List<string>();

            list4.Add("김유신");
            list4.Add("김춘추");
            list4.Add("장보고");
            list4.Add("강감찬");
            list4.Add("이순신");

            ShowObject(list4);

            List<Apple> list5 = new List<Apple>();
            list5.Add(new Apple("한국", 3000));
            list5.Add(new Apple("미국", 2000));
            list5.Add(new Apple("일본", 1000));

            foreach (Apple apple in list5) apple.Show();
        }

        static void ShowObject(IEnumerable list)
        {
            foreach (object obj in list) Console.WriteLine(obj + " ");
            Console.WriteLine();
        }
    }
}
