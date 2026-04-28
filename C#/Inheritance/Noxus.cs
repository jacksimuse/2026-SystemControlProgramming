using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // 부모 클래스
    public class Noxus
    {
        // 캐릭터 이름
        public string Name;
        // hp
        public int Hp;

        public Noxus(string name, int hp) 
        {
            Name = name;
            Hp = hp;
        }

        public virtual string QWER()
        // override 부모에서 정의된 메서드를 자식에서 재정의해서 사용
        // 부모 클래스에서는 virtual 키워드를 사용함
        {
            return $"{Name}이 스킬을 사용합니다";
        }

        // Overloading
        // 반환형 or 매개변수가 바뀌면서 메서드를 재정의 하는 개념
        public string Gohome()
        {
            return "집으로 귀환합니다";
        }

        public string Gohome(string name)
        {
            return $"{name}가 집으로 귀환합니다";
        }
    }

    // 자식 클래스
    // 자식 클래스 : 부모 클래스
    public class Dyrius : Noxus
    {
        // 자식 클래스에서는 부모의 생성자와 매칭을 해야됨
        public Dyrius(string name, int hp) : base(name, hp)
        { 
        
        }

        public override string QWER()
        // override 부모에서 정의된 메서드를 자식에서 재정의해서 사용
        // 자식 클래스에서는 override 키워드를 사용함
        {
            return $"{Name}이 도끼를 사용합니다";
        }
    }


    // 자식 클래스
    // 카타리나 만들고 스킬 사용까지 실행해봅시다
    public class Katarina : Noxus
    {
        // 자식 클래스에서는 부모의 생성자와 매칭을 해야됨
        public Katarina(string name, int hp) : base(name, hp)
        {

        }

         public override string QWER()
        // override 부모에서 정의된 메서드를 자식에서 재정의해서 사용
        // 자식 클래스에서는 override 키워드를 사용함
        {
            return $"{Name}이 칼날을 사용합니다";
        }
    }
}
