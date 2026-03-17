using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 형변환
            // 1. 암시적 형변환
            // 실수 > 정수
            int num = 1;
            double num2;
            num2 = num;

            //Console.WriteLine(num);
            //Console.WriteLine(num2);

            // 2. 명시적 형변환
            int num3;
            double num4 = 1.12;
            num3 = (int)num4;

            //Console.WriteLine(num4);
            //Console.WriteLine(num3);

            // 3. Convert 클래스 사용
            string st = Convert.ToString(num); 
            // (자료형)을 To자료형으로 변환해라
            // num이라는 숫자를 문자열로 변환해서 st라는 그릇에 넣음
            // 1 -> "1"

            //Console.WriteLine(st);

            string str = "5.1";
            //num = Convert.ToInt32(str);
            // 1 -> "1"
            // "1" -> 1
            // 문자열 -> ????

            // 4. Parse() // 숫자형에 많이 쓰임
            num4 = double.Parse(str);
            //Console.WriteLine(num4);

            // 5. TryParse() // 예외처리(오류처리)가 자동으로 됨
            int num6;
            string str2 = "123.45";
            bool a = int.TryParse(str2, out num6);

            //Console.WriteLine(a);
            //Console.WriteLine(str2);
            //Console.WriteLine(num6);

            // Q1. object와 double을 이용하여서 암시적 형변환하기 
            object ob1;
            double db1 = 1.23;
            ob1 = db1;
            // Q2. object와 int를 이용하여서 명시적 형변환하기 / short -> int
            object ob2 = 12;
            int sh;
            sh = (int)ob2;
            // Q3. Convert를 이용해서 숫자를 글자로 변환하기
            string str1 = Convert.ToString(123); // 123 -> "123"
            // Q4. Parse를 이용하여 글자를 숫자로 변환하기
            int num11 = int.Parse(str1);
            // Q5. TryParse를 이용하여 결과값이 False와 0이 나오게 만들기
            int num12;
            bool result = int.TryParse("123.45", out num12);
            Console.WriteLine(result);
            Console.WriteLine(num12);
        }
    }
}
