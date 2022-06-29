using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜: 2022/06/23
 * 이름: 박성진
 * 내용: 컬랙션 연습문제
 * 
 * Linked List
 *  - 이중 연결 리스트로 앞뒤에 참조 노드를 갖는 리스트
 *  - 일반 리스트보다 데이터 삽입, 삭제가 빠르지마 전체 검색 속도는 일반 리스트가 우수함
 *  
 * Sorted List
 *  - Hashtable과  ArrayList의 혼합형이며 내부 데이터는 Key-Value 쌍으로 구성
 *  - 내부적으로 키 값으로 정렬된 상태를 자동으로 유지
 */
namespace Test.Sub06
{
    internal class _6_08
    {
        static void Main8(string[] args)
        {
            //LinkedList

            LinkedList<string> lkList = new LinkedList<string>();
            lkList.AddFirst("김유신");
            lkList.AddFirst("김춘추");
            lkList.AddFirst("장보고");
            lkList.AddLast("강감찬");
            lkList.AddLast("이순신");
            lkList.AddLast("정약용");

            Console.WriteLine(string.Join(", ", lkList));

            LinkedListNode<string> findNode = lkList.Find("이순신");
            LinkedListNode<string> addNode1 = new LinkedListNode<string>("이성계");
            LinkedListNode<string> addNode2 = new LinkedListNode<string>("임꺽정");

            lkList.AddBefore(findNode, addNode1);
            lkList.AddAfter(findNode, addNode2);

            Console.WriteLine(String.Join(", ", lkList));
            Console.WriteLine();

            //SortedList실습

            SortedList<int, string> stList = new SortedList<int, string>();

            stList.Add(101, "한국");
            stList.Add(104, "중국");
            stList.Add(106, "대만");
            stList.Add(103, "일본");
            stList.Add(105, "호주");
            stList.Add(102, "미국");

            Console.WriteLine(String.Join(", ", stList));

            for (int i = 0; i < stList.Count; i++) Console.WriteLine("stList K: {0}, V: {1}", stList.Keys[i], stList.Values[i]);
        }
    }
}
