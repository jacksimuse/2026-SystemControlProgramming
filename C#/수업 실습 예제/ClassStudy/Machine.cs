using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudy
{
    internal class Machine
    {
        // 필드 string 팔, string 컨베이어
        public string Arm;
        public string Conveyor;


        // 24시간 전원이 켜져있는 머신
        public string Power 
        {
            get { return "On"; }
        }


        // 필드, 속성
        private string engine;
        public string Engine
        {
            // 사람이 이 필드한테 받을 수 있는 결과값
            get { return engine; }
            // 사람이 이 필드한테 지정할 수 있는 값
            set 
            {
                // 하나의 변수에 대해서 여러가지 조건으로 분류할 때 사용
                switch (value)
                {
                    case "1":
                        engine = "빨간불";
                        break;

                    case "2":
                        engine = "노란불";
                        break;

                    case "3":
                        engine = "초록불";
                        break;

                    default:
                        engine = "오류";
                        break;
                }
            }
        }





        // 생성자
        public Machine(string arm, string conveyor)
        {
            Arm = arm;
            Conveyor = conveyor;
        }
        // 메서드 팔 동작하는 메서드
        // console.writeline("팔이 동작합니다")
        public void Move()
        {
            Console.WriteLine("팔이 동작합니다");
        }

        // 컨베이어 동작하는 메서드
        // console.writeline("컨베이어가 동작합니다")
        public void Run()
        {
            Console.WriteLine("컨베이어가 동작합니다");
        }
    }
}
