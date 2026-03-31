using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeat1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. for

            // 0부터 5이전 까지 실행문을 반복한다.
            for (int i = 0; i < 5; i++) // (초기화 값; 반복 회수; 증감)
            {
                // 1. 변수 선언과 초기화
                // 2. 반복 횟수 조건 확인
                // 3. 조건이 true이면 실행문으로 이동
                // 4. 증감으로 이동
                // 5. 조건을 확인
                // 6. 조건이 false일 때까지 반복
                // Console.WriteLine(i);
            }


            // Q) 반복문을 1부터 4까지 동작하는 실행문을 만드세요 / 1~4
            // 1,2,3,4
            for (int i = 1; i <= 4; i++) // 
            {
                // Console.WriteLine(i);
            }

            // Q) 반복문을 이용해서 5부터 1까지 카운트다운을 해봅시다.
            // i-- 감소
            for (int i = 5; i >= 1; i--)
            {
                // Console.WriteLine(i);
            }


            int j = 0;

            while (j < 5) // 조건이 참일동안 계속 반복
            {
                //Console.WriteLine("안녕하세요");

                // while문 안에는 조건을 바꿔주는 요소가 필요함
                j++;
            }


            // 최초 한번 실행 후 반복문이 동작하는 구조
            // do - while()
            // do {실행시킬 반복 코드} - 1 
            // while(조건) - 2

            int k = 0;
            do
            {
                // Console.WriteLine(k);
                k++; // i = i + 1;
            }
            while (k < 5);

            // 배열
            //string fruit = "과일";

            // 자료형[] 변수 = {,,,,};
            string[] fruits = { "딸기", "사과", "포도" };

            // (자료형 변수 in 배열변수)
            // index에 접근 하기 어려운 대상을 foreach로 많이 사용
            foreach (string fruit in fruits)
            {
                //Console.WriteLine(fruit);
            }

            // index : 순서, 목차 / 컴퓨터 상에서는 0이 첫번째 숫자입니다.
            for (int i = 0; i < fruits.Length; i++)
            {
                // Console.WriteLine(fruits[i]); // 배열의 0번째 요소에 접근
            }

            // Q. do-while, foreach, for 배열의 인데스
            // Q1. do-while로 실행 한번하고 반복 3번하는 코드를 작성
            int a = 0;
            do
            {
                //  Console.WriteLine("안녕하세요");
                a++;

            } while (a < 3);

            // Q2. foreach 숫자 배열만들고 출력하기
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            foreach (int num in numbers)
            {
                //Console.WriteLine(num);
            }
            // Q3. for 숫자 배열을 만들고 홀수만 출력하기
            // 증감에서 홀, 짝 제어 가능 / 숫자 배열을 처음부터 세팅
            int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < numbers2.Length; i += 2) // 0 2 4 6 8 
            {
                // i+=2  / i = i + 2
                //Console.WriteLine(numbers2[i]);
            }

            int[] numbers3 = { 1, 3, 5, 7, 9 };
            for (int i = 0; i < numbers3.Length; i++)
            {
                Console.WriteLine(numbers3[i]);
            }
        }
        
    }
}
