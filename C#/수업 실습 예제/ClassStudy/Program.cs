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

        static void Main(string[] args)
        {
            // 공간 2 (method 안)
            Student student1 = new Student("자기 이름", 123456); // 선언과 초기화
            // class명 변수명 = new 생성자
            student1.Introduce();

            Student student2; // 선언
            student2 = new Student("학생 2", 789123);
            student2.Introduce();
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
