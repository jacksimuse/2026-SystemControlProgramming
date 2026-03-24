using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 조건문
            // if

            // 롤 캐릭터 컨트롤 하는 중

            // 만약에 ~한다면 ~게 해줘

            // 밴 픽
            // false = 밴, true = 살아있음
            bool 아우솔 = true; // bool 상자에 true 값은 선언과 초기화
            if (아우솔 == true) // == 같다
            {
                아우솔 = false;
            }

            // if와 else
            bool 신발 = false; // 신발을 사면 true, 안사면 false
            if (신발 == false) // 신발이 없으면(안 샀으면)
            {
                신발 = true; // 신발을 산다
            }
            else // if 이외의 조건 모두
            {
                신발 = false; // 신발을 판다
            }

            // if, else if, else /
            // if조건 이외에 다른 조건을 넣을때 else if를 넣는다
            string mid = "faker";
            string top = "doran";
            string support = "keria";
            string ad = "adfasf";
            string jg = "123";

            if (mid == "")
            {
                Console.WriteLine("미드선수");
            }
            else if (top == "")
            {
                Console.WriteLine("서폿으로 가야함");
            }
            else if (ad == "")
            {
                Console.WriteLine("원딜");
            }
            else
            {
                Console.WriteLine("배정완료");
            }

            // if문 사용방법
            // if (조건)
            // { 실행할 내용 }
            // else if (조건) / 개수 상관없음
            // { 실행할 내용}
            // else  / 위 조건 이외의 모든 내용을 받아줌
            // { 실행할 내용}

        }
    }
}
