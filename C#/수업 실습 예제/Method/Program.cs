using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // 메서드 호출 / 클래스이름.함수이름();
            Program.Sum();
            Program.Sub(2, 1);
           // Console.WriteLine(Program.Mul());
            Console.WriteLine(Program.Div(4,2));
        }
        
        // Method는 동작을 나타내는 함수
        // 1. 매개변수(parameter) x, 반환(return) x
        
        // 더하기 함수를 만들어봅시다.
        static void Sum() 
        {
            //Console.WriteLine(1 + 2);
        }

        // 2. 매개변수(parameter) o, 반환(return) x

        // 빼기 함수를 만들어봅시다.
        static void Sub(int a, int b)
        {
           // Console.WriteLine(a - b);
        }

        // 3. 매개변수(parameter) x, 반환(return) o

        // 곱하기 함수를 만들어봅시다.
        static int Mul()
        {
            return 3 * 2;
        }

        // 4. 매개변수(parameter) o, 반환(return) o

        // 나누기 함수를 만들어봅시다.
        static int Div(int a, int b)
        {
            return a / b;
        }

        // Q 메서드 4개 만들기
        // 문자를 주고 받고 할겁니다.
        // 1. 매개변수 x 반환 x
        // intro 라는 함수 만들고 자기 이름 출력되게하기

        // 2. 매개변수 o 반환 x
        // 함수 호출할때 자기 이름을 전달하고 출력되게하기

        // 3. 매개변수 x 반환 o
        // 함수 호출하면 자기 이름이 반환되게 하고 받은 값을 출력되게 하기

        // 4. 매개변수 o 반환 o
        // 함수 호출할때 자기 이름을 전달하고 이름 + 나이를 반환되게하고 받은 값을 출력되게 하기
    }
}
