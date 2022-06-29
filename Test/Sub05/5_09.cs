using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜: 2022/06/23
 * 이름: 박성진
 * 내용: 스택 연습문제
 */
namespace Test.Sub05
{
    class MyStack
    {
        const int maxSize = 10;
        private int[] arr = new int[maxSize];
        private int top;

        public MyStack()
        {
            top = 0;
        }

        public void Push(int val)
        {
            if(top < maxSize)
            {
                arr[top] = val;
                top++;
            }
            else
            {
                Console.WriteLine("Stack Full");
                return;
            }
        }

        public int Pop()
        {
            if(top > 0)
            {
                top--;
                return arr[top];
            }
            else
            {
                Console.WriteLine("StackEmpty");
                return default(int);
            }
        }
    }
    
    internal class _5_09
    {
        static void Main9(string[] args)
        {
            MyStack mStack = new MyStack();
            Random random = new Random();

            for(int i =0; i < 10; i++)
            {
                int val = random.Next(1, 100);
                mStack.Push(val);
                Console.WriteLine($"Push({val})");
            }
            Console.WriteLine();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Pop() = {mStack.Pop()}");
            }
        }
    }
}
