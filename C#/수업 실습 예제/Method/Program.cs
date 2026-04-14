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
            // Program.Sum();
            // Program.Sub(2, 1);
            //// Console.WriteLine(Program.Mul());
            // Console.WriteLine(Program.Div(4,2));
           // Console.WriteLine(Intro4("이름", 100));

            //Intro5(123);

            int a = 100;
            Num1(a);
            //Console.WriteLine(a);
            Num2(ref a); // 키워드가 있는 것은 키워드와 함께 값을 던져줌
            //Console.WriteLine(a);

            int b; // out 값을 받기 위한 변수를 미리 선언해둠
            string result = Finger(out b, out int sec, out int thi, out int four, out int thj); // out과 동시 변수를 선언
            if (result == "완료")
            {
               // Console.WriteLine("코드 진행");
            }
            else
            {
               // Console.WriteLine("다시 실행");
            }

            // 1. 기본값
            Console.WriteLine(Department());
            Console.WriteLine(Department("00과"));

            // 2. ref 
            int mul = 100;
            Mul3(ref mul);
            Console.WriteLine(mul);

            // 3. out
            if (Make(out string aa, out string bb))
            {
                Console.WriteLine(aa + " " + bb);
            }



            // 지역변수 / ref를 떠올리면 이해하기 쉬움
            int abc = 123;
            Num3(abc);
            // 외부에서는 적용 안됨
           

            // 전역변수 / 전체 구역에서 사용 가능

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
        void Intro()
        {
            Console.WriteLine("자기 이름");
        }

        // 2. 매개변수 o 반환 x
        // 함수 호출할때 자기 이름을 전달하고 출력되게하기
        void  Intro2(string name)
        {
            Console.WriteLine(name);
        }


        // 3. 매개변수 x 반환 o
        // 함수 호출하면 자기 이름이 반환되게 하고 받은 값을 출력되게 하기
        string Intro3()
        {
            return "이름";
        }

        // 4. 매개변수 o 반환 o
        // 함수 호출할때 자기 이름을 전달하고 이름 + 나이를 반환되게하고 받은 값을 출력되게 하기
        static string Intro4(string name, int age)
        {
            return name + "   " + age;
        }

        // 매개변수 키워드

        // 1. 기본값 / Default  디폴트
        // 2. ref (reference 참조) / 호출할때 던져주는 값이 그대로 복사가 된다.
        // 3. out / 반환값은 1개만 가능한데, 여러개 받고 싶을 때 사용
        static string Intro5(int age, string name = "자기 이름") // 기본값이 필요한 매개변수는 맨 뒤쪽에 두더라
        {
            return name + "   " + age;
        }

        static int Num1(int a)
        {
            a++;
            return a;
        }
        static int Num2(ref int a)
        {
            a++; 
            return a;
        }

        // 손가락 로봇을 제어한다는 가정

        static string Finger(out int first, out int second, out int third, out int fourth, out int fifth)
        {
            first = 1;
            
            //if (first != 1) 
            //{
            //    return "실패";
            //}

            second = 2;
            third = 3;
            fourth = 4;
            fifth = 5;

            return "완료";
        }


        // 1. 기본값
        // 2. ref
        // 3. out 

        // 1. 기본값이 "반도체장비과" 가 들어가게 해서 함수를 만들고 매개변수 없이 호출, 매개변수 넣어서 호출
        static string Department(string a = "반도체 장비과")
        {
            return $"우리 학과는 {a} 입니다";
        }
        // 2. 숫자 변수를 만들고 ref를 사용해서 값 참조가 일어나는지 확인하기 / 함수에는 *3 해서 값 돌려주기
        static int Mul3(ref int a)
        {
            a *= 3;
            return a;
        }

        // 3. out 키워드 사용해서 2개는 out으로 받고 1개는 반환형으로 받아오기
        static bool Make(out string wafer, out string steal)
        {
            wafer = "웨이퍼";
            steal = "금속";
            return true;
        }

        static void  Num3(int region)
        {
            // 지역변수 / 변수가 생성된 곳에서만 살아있음
            region = 1;
        }
    }
}
