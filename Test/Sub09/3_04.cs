using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜: 2022/06/29
 * 이름: 박성진
 * 내용: [총정리 문제] 버블 정렬
 */
namespace Test.Sub09
{
    internal class _3_04
    {
        static void Main4(string[] args)
        {
            int[] values = { 3, 5, 2, 7, 1 };
            PrintArray(values);

            for(int i = 4; i > 0; i --)
            {
                for(int j =0; j< i; j++)
                {
                    if (values[j] > values[j + 1])
                    {
                        int temp = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = temp;
                    }
                }
                PrintArray(values);
            }
        }
        public static void PrintArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("{0,4}", array[i]);
            }
            Console.WriteLine();
        }
    }
}
