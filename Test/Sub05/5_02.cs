using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜: 2022/06/23
 * 이름: 박성진
 * 내용: 예외처리 연습문제
 */
namespace Test.Sub05
{
    class NotFoundExeiption : Exception
    {
        public NotFoundExeiption() : base("해당하는 수자를 찾을 수 없습니다.") { }
    }
    internal class _5_02
    {
        static void Main2(string[] args)
        {
            int[] arr = { 2, 4, 6, 8, 10 };

            Console.Write("찾을 숫자 입력: ");
            
            try
            {
                int find = Convert.ToInt32(Console.ReadLine());

                searchArray(find, arr);
                Console.WriteLine("해당하는 숫자 찾음!!");
            }
            catch(NotFoundExeiption e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("프로그램 정상 종료");
        }

        public static void searchArray(int find, int[] arr)
        {
            foreach(int i in arr)
            {
                if (i == find) return;
            }

            throw(new NotFoundExeiption());
        }
    }
}
