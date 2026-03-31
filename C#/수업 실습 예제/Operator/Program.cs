using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 산술연산자
            //Console.WriteLine(1 + 2); // + 더하기
            //Console.WriteLine(1 - 2); // - 빼기
            //Console.WriteLine(1 * 2); // * 곱하기
            //Console.WriteLine(1 / 2); // / 나누기(몫)
            //Console.WriteLine(1 % 2); // % 나누기(나머지)

            // 2. 할당연산자
            int a = 1; // 할당
            a += 2; // 더하기 할당 / a = a + 2;
            a -= 3; // 빼기 할당 / a = a - 3;
            a *= 4; // 곱하기 할당 / a = a * 4;
            a /= 5; // 나누기(몫) 할당 / a = a / 5;
            a %= 6; // 나누기(나머지) 할당 / a = a % 6;

            // 3. 비교연산자
            // == != > >= < <=
            // 반도체 장비 운영
            // 장비가 운전(시동중) ? 
            bool power = false; // 장비 전원 꺼져있음
            if (power == false) // 장비가 꺼져있음?
            {
                power = true; // 장비 켜
            }

            if (power != true) // 장비가 켜져있지 않음?
            {
                power = true; // 장비 켜
            }

            int run = 0; // (장비) 동작하다
            // 반도체 웨이퍼를 만드는 기계 동작중
            while (run <= 3)  // > >=
            {
               // Console.WriteLine("가열 시동");
                run++;
            }

            // 4. 논리 연산자
            // &&, ||, ! 
            // 둘다 참 / 하나만 참 / 조건을 부정

            // a버튼, b버튼이 있고 둘다 눌려야 동작한다.
            // 긴급정지 버튼을 만드는 중
            
            bool buttonA = false; // 눌리면 true, 안눌리면 false
            bool buttonB = false;

            if (!buttonA && !buttonB) // true && true -> true
            {
             //   Console.WriteLine("긴급 정지");
            }

            // 버튼 a 또는 버튼 c 중 하나만 눌리면 되는 상황
            bool buttonC = false;
            if (buttonA || !buttonC)
            {
              //  Console.WriteLine("동작");
            }

            // 삼항 연산자
            // 조건에 맞는 값을 받을 때 사용 
            // Signal Tower
            // error / normal

            int signal = 0; // 0 이면 정상 , 1이면 에러
            string state = (signal == 0) ? "정상" : "에러"; // (조건) ? 맞으면 왼쪽 : 틀리면 오른쪽
            Console.WriteLine(state);

           
        }
    }
}
