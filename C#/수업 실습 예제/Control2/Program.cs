using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // switch 하나의 변수에 따라서 case를 나눈다
            string rainbow = "파";

            switch (rainbow) // switch (조건 = 변수명)
            {
                case "빨": // case 변수 자료형과 같은 내용: 
                    Console.WriteLine("빨"); // 중괄호 없이 실행문을 작성함
                    Console.WriteLine("빨간색 아니었음");
                    break; // case와 한 쌍 break, 조건 실행문의 마침표 같은 역할


                case "주": // 실행이 같은 곳에서 작동해야 된다면 case를 합칠 수 있다.
                case "노":
                case "초":
                    Console.WriteLine("주");
                    Console.WriteLine("노");
                    Console.WriteLine("초");
                    break;

                case "파":
                    Console.WriteLine("파");
                    goto case "남"; // 해당 case문의 실행문으로 이동함
                    break;

                case "남":
                    Console.WriteLine("남");
                    break;

                default:
                    Console.WriteLine("보");
                    break;
            }


            // 손, 팔, 다리, 발이 달린 로봇이 있다고 생각
            // 1. 물건이 온다
            // 2. 손이 앞으로 나간다.
            // 3. 다리가 나간다.
            // 4. 팔이 나간다.

            // case "손": 앞으로 나감 break;
            // case "팔": 앞으로 나감 break;
            // case "다리": 앞으로 나감 break;
            // case "발": 앞으로 나감 break;

            // 손, 다리가 동시에 작동하도록 코드를 작성하시오
            // case "손":
            // case "다리":
            //      Console.WriteLine("움직인다");
            //  break;

            // 팔이 움직인 다음 발이 나가도록 코드를 작성하시오
            // case "팔":
            //      Console.WriteLine("팔이 움직인다");
            //      goto case "발";
            // case "발":
            //      Console.WriteLine("발이 움직인다");
            //  break;


            // Q) 0,1이 신호로 들어옵니다. 
            // A 실린더, B 실린더, C 실린더 / 전진, 후진 10, 01
            // A 실린더 전진, B 실린더 후진, C 실린더 전진인 신호가 컴퓨터로 들어옴
            // "100110" -> 10/01/10

            // 각 실린더의 상태를 파악하고 조건을 나눠 콘솔에 출력합시다.
            // 조건 A 실린더 전진, 후진 / B 실린더 전진, 후진 / C 실린더 전진, 후진
            // switch문을 만들어봅시다. 

            string abc = "A 실린더 전진";

            switch (abc)
            {
                case "A 실린더 전진":
                    Console.WriteLine("A 실린더 전진");
                    break;
                case "A 실린더 후진":
                    Console.WriteLine("A 실린더 후진");
                    break;
                case "B 실린더 전진":
                    Console.WriteLine("B 실린더 전진");
                    break;
                case "B 실린더 후진":
                    Console.WriteLine("A 실린더 후진");
                    break;
                case "C 실린더 전진":
                    Console.WriteLine("C 실린더 전진");
                    break;
                case "C 실린더 후진":
                    Console.WriteLine("C 실린더 후진");
                    break;
            }

        }
    }
}
