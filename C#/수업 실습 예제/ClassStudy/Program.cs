using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudy
{
    internal class Program
    {
        // 공간 1 (class 안)
        // 필드(전역변수), 메서드, 생성자 정의하는 / 들어가는 공간

        static void Main(string[] args)
        {
            // 공간 2 (method, 생성자 안)
            // 정의되어있는 클래스나 메서드, 전역변수(필드)를 사용하는 공간

            //Student student1 = new Student("자기 이름", 123456); // 선언과 초기화
            //// class명 변수명 = new 생성자
            //student1.Introduce();

            //Student student2; // 선언
            //student2 = new Student("학생 2", 789123);
            //student2.Introduce();


            // machine 2개 소환
            // machine1,2를 생성하고 메서드 호출까지 하기
            Machine machine1 = new Machine("로봇팔", "컨베이어");
            //machine1.Move();
            //machine1.Run();
            machine1.Engine = "1";
            Console.WriteLine(machine1.Engine);


            Console.WriteLine(machine1.Power);
            machine1.Power = "Off";
            Console.WriteLine(machine1.Power);


            Machine machine2 = new Machine("팔팔", "컨베이어2");
            //machine2.Move();
            //machine2.Run();
        }
    }


    class Student
    {
        // 필드(전역변수)
        public string Name;
        public int Number;

        // 생성자
        // 클래스 명(매개변수)
        // {
        //      실행문;
        // }

        public Student(string name, int number)
        {
            Name = name;
            Number = number;
        }

        // 메서드
        public void Introduce()
        {
            Console.WriteLine($"학생 이름 : {Name}, 학번 : {Number}");
        }
    }

}
