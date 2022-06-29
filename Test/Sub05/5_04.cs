using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜: 2022/06/23
 * 이름: 박성진
 * 내용: 로또 연습문제
 */

namespace Test.Sub05
{
    internal class _5_04
    {
        static void Main4(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                SortedSet<int> set = new SortedSet<int>(MakeLotto());

                foreach(int n in set)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }

        public static SortedSet<int> MakeLotto()
        {
            SortedSet<int> set = new SortedSet<int>();
            Random random = new Random();
            for(; ; )
            {
                int num = random.Next(1, 46);
                set.Add(num);

                if (set.Count == 6) break; 
            }

            return set;
        }
    }
}
