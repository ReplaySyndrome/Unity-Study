using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. ++i와 i++의 차이점은 무었인가요
            // ++i는 전위 연산자로 증가를 시킨뒤 문장을 실행한다
            // i++은 후위 연산자로 문장을 실행한뒤 증가를 시킨다.

            //2. 다음중 결과라 다른 하나는?
            //① i = i+ 1;
            //② i++;
            //③ ++i;
            //④ i += 1
            //
            //정답 2번 후위연산이므로 Write를 한다고 하면 2번은 다른 값들 보다 하나만큼 작은 값이 출력된다

            //3. 다음 코드에서 a 와 b는 각각 얼마일까요?
            //int a = 8 >> 1;
            //Console.WriteLine(a); //출력값 4
            //int b = a >> 2;
            //Console.WriteLine(b); // 출력값 1
            //
            // 8은 2진수로 1000이다
            // 1000 을 오른쪽으로 1번 쉬프트하면 0100 이므로 4이다.
            // 0100 을 오른쪽으로 2번 쉬프트하면 0001이므로 1이다.

            // 4. 다음 코드에서 a는 얼마일까요?
            //int a = 0xF0 | 0x0F;
            //Console.WriteLine(a); // 255
            //OR연산자이므로 16진수 F0과 0F를 OR연산을 하면 FF가 된다

            //5. 다음 코드에서 b는 어떤 값을 가질까요
            //int a = 10;
            //string b = a == 0? "가나다" : "ABC";
            //Console.WriteLine(b);
            //
            // a에는 10이 할당되어 있다. a는 0이 아니므로 뒤에 값인 ABC가 string형태로 b에 저장된다.
        }
    }
}
