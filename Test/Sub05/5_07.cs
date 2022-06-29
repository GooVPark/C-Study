﻿using System;
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
    internal class _5_07
    {
        static void Main7(string[] args)
        {
            while(true)
            {
                Game();
                Console.WriteLine("-----------------");
                Console.WriteLine("0: 종료, 1: 한번 더 하기");
                Console.Write("입력: ");

                int anwer = int.Parse(Console.ReadLine());

                if (anwer == 0) break;
            }
            Console.WriteLine("게임 종료");
        }

        static void Game()
        {
            string[] words = { "가위", "바위", "보" };

            string comWord = null;
            string youWord = null;

            while(true)
            {
                Console.Write("가위, 바위, 보 입력: ");
                try
                {
                    youWord = Console.ReadLine();
                    if (!words.Contains(youWord)) throw new Exception("가위, 바위, 보 중에서 하나만 내세요.");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                break;
            }
            
            Random random = new Random();
            comWord = words[random.Next(3)];

            Console.WriteLine("컴퓨터 결과: " + comWord);
            if (comWord == "가위" && youWord == "가위") Console.WriteLine("무승부");
            else if (comWord == "가위" && youWord == "바위") Console.WriteLine("당신의 승리");
            else if (comWord == "가위" && youWord == "보") Console.WriteLine("컴퓨터의 승리");
            else if (comWord == "바위" && youWord == "가위") Console.WriteLine("컴퓨터의 승리");
            else if (comWord == "바위" && youWord == "바위") Console.WriteLine("무승부");
            else if (comWord == "바위" && youWord == "보") Console.WriteLine("당신의 승리");
            else if (comWord == "보" && youWord == "가위") Console.WriteLine("당신의 승리");
            else if (comWord == "보" && youWord == "바위") Console.WriteLine("컴퓨터의 승리");
            else if (comWord == "보" && youWord == "보") Console.WriteLine("무승부");
        }
    }
}
