using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜: 2022/06/17
 * 이름: 박성진
 * 내용: Indexer 연습문제
 */
namespace Test.Sub04
{
    class MYIndexer<T>
    {
        private T[] array = new T[10];

        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
    }
    internal class _4_06
    {
        static void Main6(string[] args)
        {
            var myIndexer = new MYIndexer<string>();

            myIndexer[0] = "Hello, World!";
            myIndexer[1] = "Hello, Korea!";
            myIndexer[2] = "Hello, Busan!";
            myIndexer[3] = "Hello, C#!";

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(myIndexer[i]);
            }
        }
    }
}
