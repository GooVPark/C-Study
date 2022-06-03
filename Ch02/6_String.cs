using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/06/02
 * 이름: 박성진
 * 내용: 문자열(string) 처리 실습 교쟈 p112
 */
namespace Ch02
{
    internal class _6_String
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";
            Console.WriteLine($"greeting: {greeting}");
            Console.WriteLine();

            //문자열 길이
            Console.WriteLine($"greeting의 길이: {greeting.Length}");
            Console.WriteLine();

            //문자열 추출
            Console.WriteLine($"greeting[0]: {greeting[0]}");
            Console.WriteLine($"greeting[3]: {greeting[3]}");
            Console.WriteLine($"greeting[5]: {greeting[5]}");
            Console.WriteLine();

            //IndexOf
            Console.WriteLine($"IndexOf: 'G': {greeting.IndexOf('G')}");
            Console.WriteLine($"IndexOf: \"G\": {greeting.IndexOf("G")}");
            Console.WriteLine($"IndexOf: 'o': {greeting.IndexOf('o')}");
            Console.WriteLine($"IndexOf: \"Mor\": {greeting.IndexOf("Mor")}");
            Console.WriteLine($"IndexOf: \"ing\": {greeting.IndexOf("ing")}");
            Console.WriteLine();

            //LastIndexOf
            Console.WriteLine($"LastIndexOf 'G': {greeting.LastIndexOf('G')}");
            Console.WriteLine($"LastIndexOf: \"G\": {greeting.LastIndexOf("G")}");
            Console.WriteLine($"LastIndexOf: 'o': {greeting.LastIndexOf('o')}");
            Console.WriteLine($"LastIndexOf: \"Mor\": {greeting.LastIndexOf("Mor")}");
            Console.WriteLine($"LastIndexOf: \"ing\": {greeting.LastIndexOf("ing")}");
            Console.WriteLine();

            //Substring
            Console.WriteLine($"Substring(0, 4): {greeting.Substring(0, 4)}");
            Console.WriteLine($"Substring(5, 7): {greeting.Substring(5, 7)}");
            Console.WriteLine($"Substring(5): {greeting.Substring(5)}");
            Console.WriteLine();

            //Replace
            string replaced = greeting.Replace("Morning", "Afternoon");
            Console.WriteLine($"Replaced: {replaced}");
            Console.WriteLine();

            //기본형 데이터를 문자열로 변환
            int var1 = 1;
            double var2 = 2.13;
            bool var3 = true;

            string str1 = var1.ToString();
            string str2 = var2.ToString();
            string str3 = var3.ToString();

            Console.WriteLine($"str1: {str1}");
            Console.WriteLine($"str2: {str2}");
            Console.WriteLine($"str3: {str3}");
            Console.WriteLine();

            //문자열 데이터를 기본형으로 변환
            string str4 = "3";
            string str5 = "3.14";
            string str6 = "false";

            int var4 = int.Parse(str4);
            double var5 = double.Parse(str5);
            bool var6 = bool.Parse(str6);

            Console.WriteLine($"var4: {var4}");
            Console.WriteLine($"var5: {var5}");
            Console.WriteLine($"var6: {var6}");
            Console.WriteLine();
        }
    }
}
