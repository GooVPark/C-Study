using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/06/03
 * 이름: 박성진
 * 내용: 조건문 switch 실습 교재 p127
 */

namespace Ch03
{
    internal class _2_Switch
    {
        static void Main(string[] args)
        {
            Console.Write("점수 입력: ");
            string strScore = Console.ReadLine();

            int score = int.Parse(strScore);
            int grade = score / 10;

            char rank;
            switch(grade)
            {
                case 10:
                case 9:
                    rank = 'A';
                    break;
                case 8:
                    rank = 'B';
                    break;
                case 7:
                    rank = 'C';
                    break;
                case 6:
                    rank = 'D';
                    break;
                default:
                    rank = 'F';
                    break;
            }

            Console.WriteLine($"{rank} 입니다.");
        }
    }
}
