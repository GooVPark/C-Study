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
 * 내용: 컬렉션 Hashtable/Dictionary 실습하기
 */
namespace Ch07
{
    internal class _4_Hashtable
    {
        static void Main4(string[] args)
        {
            Hashtable table = new Hashtable();

            table['A'] = "Apple";
            table['B'] = "Banana";
            table['C'] = "Cherry";

            Console.WriteLine($"table[A]: {table['A']}");
            Console.WriteLine($"table[B]: {table['B']}");
            Console.WriteLine($"table[C]: {table['C']}");

            foreach(char key in table.Keys)
            {
                Console.WriteLine($"table[{key}]: {table[key]}");
            }

            Dictionary<char, string> dic = new Dictionary<char, string>();
            dic.Add('A', "Apple");
            dic.Add('B', "Banana");
            dic.Add('C', "Cherry");

            foreach(char key in dic.Keys)
            {
                Console.WriteLine($"dic[{key}]: {dic[key]}");
            }

            foreach(string value in dic.Values)
            {
                Console.WriteLine($"value: {value}");
            }

            Dictionary<int, string> people = new Dictionary<int, string>();

            people.Add(101, "김유신");
            people.Add(102, "김춘추");
            people.Add(103, "장보고");
            people.Add(104, "강감찬");
            people.Add(105, "이순신");

            foreach (int key in people.Keys) Console.WriteLine($"{key}: {people[key]}");

            Dictionary<int, Apple> d1 = new Dictionary<int, Apple>();
            Dictionary<int, Apple> d2 = new Dictionary<int, Apple>();
            Dictionary<int, Apple> d3 = new Dictionary<int, Apple>();

            d1.Add(101, new Apple("한국", 3000));
            d1.Add(102, new Apple("미국", 2000));
            d1.Add(103, new Apple("일본", 1000));

            d2.Add(201, new Apple("중국", 3000));
            d2.Add(202, new Apple("대만", 2000));
            d2.Add(203, new Apple("홍콩", 1000));
            
            d3.Add(301, new Apple("호주", 3000));
            d3.Add(302, new Apple("영국", 2000));
            d3.Add(303, new Apple("인도", 1000));

            List<Dictionary<int, Apple>> apples = new List<Dictionary<int, Apple>>();
            apples.Add(d1);
            apples.Add(d2);
            apples.Add(d3);

            apples[0][101].Show();
            apples[0][102].Show();
            apples[1][202].Show();
            apples[2][303].Show();
        }
    }
}
