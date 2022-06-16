using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/06/09
 * 이름: 박성진
 * 내용: 조건문 연습문제
 */

namespace Test.Sub01
{
    internal class _1_06
    {
        static void Main06(string[] args)
        {
            Console.Write("점수 입력 : ");
            int score = int.Parse(Console.ReadLine());
            char grade;

            Console.Write("입력한 점수는 {0}점 이고, 등급은 ", score);

            if(score >= 90)
            {
                grade = 'A';
            }
            else if(score >= 80)
            {
                grade = 'B';
            }
            else if(score >= 70)
            {
                grade = 'C';
            }
            else if(score >= 60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }

            Console.Write("{0}입니다", grade);
        }
    }
}
