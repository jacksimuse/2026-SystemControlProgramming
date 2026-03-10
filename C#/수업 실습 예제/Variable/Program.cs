using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 변수 만들기, 변수 선언와 초기화
            // 자연수 : 1, 2, 3,...~무한대
            // 정수 : 부호가 있는 숫자, -1, 0 ,1..... 

            int variable; // 변수 선언, 초기화 안됨
            // 초기화는 맨처음에 변수 선언하고 생성된 상자에 값을 넣어주는 행위
            variable = 10; // = 를 기준으로 오른쪽 값을 왼쪽에 넣는다.

            int a = 1; // 변수 선언과 동시에 초기화

            // Q : 정수를 담을 변수를 만들고 숫자 -5를 초기화 해봅시다.
            int b = -5;

            int c;
            c = -5;


            // 실수형 : 부호가 있고 소수점까지 표현한 숫자
            double d = 3.14;
            // 문자형 : 문자 하나를 담을수 있다.
            char e = 'b';
            // 문자열 : 문자들의 나열
            string f = "문자열";
            // 불리언 : true, false를 담는 공간 / 참, 거짓
            bool g = true;

            // Q : 정수, 실수, 문자, 문자열, 불리언 하나씩 선언과 초기화를 해보자

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
        }
    }
}
