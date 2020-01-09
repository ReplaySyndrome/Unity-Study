using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChapter7
{
    class A
    { }

    class B:A
    {

    }


    class Program
    {
        static void Main(string[] args)
        {
            //1. 클래스와 객체, 인스턴스는 서로 어떤 점이 다른가요?
            //  클래스는 객체를 만들어 낼 수 있는 또 하나의 데이터 형식이다
            //  객체는 클래스를 통해서 만들어낸 데이터이다. 
            //  인스턴스는 객체를 저장하고 있는 실체이다.

            //2. 다음 코드애서 오류를 찾고 오류의 원인을 설명하세요
            //A a = new A();
            //B b = new B();
            //A c = new B();
            //B d = new A();
            // B는 A를 상속받고있으므로 A에 B를 할당할 수 있지만 B에 A를 할당할 수는 없다

            //3.this 키워드와 base키워드에 대해 설명하시오
            // this는 클래스 내에서 나 자신에게 접근할 수 있고 base는 하위 클래스에서 상위클래스에 접근하는 키워드이다.


            //4. 구조체에 대한 다음 설명중 틀린것을 고르세요
            // 1 STRUCT 키워드를 이용하여 선언한다.
            // 2 복사할 때 얕은 복사가 이루어진다.
            // 3 참조 형식이다.
            // 4 메소드를 가질 수 있다.
            //
            // 구조체는 값 형식이고 복사할 때 깊은 복사가 이루어지며 메소드는 가질 수 있다.  (2,3)

            //5. 다형성은 무엇이며 오버라이딩과 무슨 관계가 있는지 설명하세요
            // 객체가 여러가지 형태를 가질 수 있음을 의미한다. 다형성을 구현하기 위해 오버라이딩을 사용한다.

        }
    }
}
