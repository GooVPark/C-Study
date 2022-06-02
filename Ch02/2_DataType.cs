using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/06/02
 * 이름: 박성진
 * 내용: 자료형(Data Type) 실습하기 교쟈 p83
 * 
 * 자료형(Data Type)
 * -변수에 저장되는 데이터의 종류와 크기를 자료형으로 선언
 * -자료형은 크게 기본형과 참조형으로 나뉨
 */

namespace Ch02
{
    internal class _2_DataType
    {
        static void Main2(string[] args)
        {
            //정수형
            sbyte num1 = 127;
            byte num2 = 255;
            short num3 = 32767;
            int num4 = 2147483647;
            long num5 = 2147483648L;

            Console.WriteLine("num1: {0}", num1);
            Console.WriteLine("num2: {0}", num2);
            Console.WriteLine("num3: {0}", num3);
            Console.WriteLine("num4: {0}", num4);
            Console.WriteLine("num5: {0}", num5);

            //실수형
            float var1 = 1.23456789f;
            double var2 = 1.2345678901234567890;

            Console.WriteLine("var1: {0}", var1);
            Console.WriteLine("var2: {0}", var2);

            //논리형
            bool b1 = true;
            bool b2 = false;

            Console.WriteLine("b1: {0}", b1);
            Console.WriteLine("b2: {0}", b2);

            //문자형
            char c1 = 'A';
            char c2 = '가';

            Console.WriteLine("c1: {0}", c1);
            Console.WriteLine("c2: {0}", c2);

            //문자열
            string str1 = "A";
            string str2 = "가";
            string str3 = "Apple";
            string str4 = "안녕하세요.";
            string str5 = "10";


            Console.WriteLine("str1: {0}", str1);
            Console.WriteLine("str2: {0}", str2);
            Console.WriteLine("str3: {0}", str3);
            Console.WriteLine("str4: {0}", str4);
            Console.WriteLine("str5: {0}", str5);

            //object 형
            object obj1 = 11;
            object obj2 = 3.1415;
            object obj3 = true;
            object obj4 = 'A';
            object obj5 = "Apple";

            Console.WriteLine("obj1: {0}", obj1);
            Console.WriteLine("obj2: {0}", obj2);
            Console.WriteLine("obj3: {0}", obj3);
            Console.WriteLine("obj4: {0}", obj4);
            Console.WriteLine("obj5: {0}", obj5);
            
            //var 형
            var v1 = 11;
            var v2 = 3.1415;
            var v3 = true;
            var v4 = 'A';
            var v5 = "Apple";

            Console.WriteLine("v1: {0}", v1);
            Console.WriteLine("v2: {0}", v2);
            Console.WriteLine("v3: {0}", v3);
            Console.WriteLine("v4: {0}", v4);
            Console.WriteLine("v5: {0}", v5);
        }
    }
}
