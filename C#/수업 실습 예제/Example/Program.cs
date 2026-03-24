using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-변수 선언과 초기화, 형변환 5가지
            //Q1) 변수 선언과 초기화하기
            int a = 1; // 정수 
            double b = 2.12;  // 실수
            char c = 'c'; // 문자 1개
            string d = "문자열"; // 문자열
            bool e = false; // true, false

            //  Q2) 숫자, 문자형 변수 만들고 형변환 5가지 적용하기
            int aa = 123;
            double bb;
            string str;
            // 1. 암시적 형변환
            bb = aa;
            // 2. 명시적 형변환
            aa = (int)bb;
            // 3. Convert 클래스 사용
            str = Convert.ToString(aa);
            // 4. Pasre 사용
            bb = double.Parse(str);
            // 5. TryParse 사용
            bool bl = int.TryParse(str, out aa);

            //-조건문
            //Q3) if 사용해서 조건마다 빨, 주, 노, 초, 파, 남, 보 출력 되게 만들기
            string rainbow = "초";

            if (rainbow == "빨")
            {
                Console.WriteLine("빨");
            }
            else if (rainbow == "주")
            {
                Console.WriteLine("주");
            }
            else if (rainbow == "노")
            {
                Console.WriteLine("노");
            }
            else if (rainbow == "초")
            {
                Console.WriteLine("초");
            }
            else if (rainbow == "파")
            {
                Console.WriteLine("파");
            }
            else if (rainbow == "남")
            {
                Console.WriteLine("남");
            }
            else 
            {
                Console.WriteLine("보");
            }

        }
    }
}
