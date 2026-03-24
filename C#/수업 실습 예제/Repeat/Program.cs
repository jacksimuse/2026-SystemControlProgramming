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
            for(int i = 5; i >= 1 ; i--)
            {
               // Console.WriteLine(i);
            }


            int j = 0;
            
            while (j < 5) // 조건이 참일동안 계속 반복
            {
                Console.WriteLine("안녕하세요");

                // while문 안에는 조건을 바꿔주는 요소가 필요함
                j++;
            }
        }
    }
}
