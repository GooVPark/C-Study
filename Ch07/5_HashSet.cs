using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜: 2022/06/15
 * 이름: 박성진
 * 내용: 컬랙션 HahSet 실습하기
 */
namespace Ch07
{
    internal class _5_HashSet
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();

            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Add(5);
            set.Add(2);
            set.Add(3);

            Console.WriteLine("집합의 원소의 개수: " + set.Count);

            foreach(int n in set)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4, 5};
            HashSet<int> set2 = new HashSet<int>() { 2, 3, 5, 6, 7};

            var intersection = set1.Intersect(set2);
            var union = set1.Union(set2);
            var except = set1.Except(set2);

            foreach (int n in intersection) Console.Write(n + " ");
            Console.WriteLine();
            foreach (int n in union) Console.Write(n + " ");
            Console.WriteLine();
            foreach (int n in except) Console.Write(n + " ");
            Console.WriteLine();
        }
    }
}
