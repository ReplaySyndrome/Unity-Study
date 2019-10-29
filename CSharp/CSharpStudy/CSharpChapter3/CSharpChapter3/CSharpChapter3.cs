using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharpChapter3
{
    class CSharpChapter3
    {
        static void Main(string[] args)
        {
            ////연습문제 1번
            //int a = 7.3;           //->정수형 타입에 실수형 타입을 대입하려 한다 
            //float b = 3.14f;       //->f한정자를 이용하여 float 타입임을 명시하지 않았다.
            //double c = a * b;      //int형태와 float 형태를 곱해서 double 형태에 대입하면 큰 문제는 될 것같지 않다
            //char d = "abc";        //string 타입을 char타입에 대입하려 한다.
            //string e = '한';       //char 타입을 string 타입에 대입하려 한다.

            //연습문제 2번
            //값형식과 참조 형식의 차이
            //값형식 : 값을 저장하고 있는 스택에 직접 접근하는것
            //참조 형식: 힙 영역에 저장되어 있는 값을 주소를 통해 접근하는것

            //연습문제 3번
            //박싱: 힙 영역에 값을 저장하는것
            //언박싱 : 박싱되어 있는 값을 꺼내 사용하는 것

            ////연습문제 4번 
            //WriteLine("사각형의 넓이를 입력하세요");
            //string width = ReadLine();
            //WriteLine("사각형의 높이를 입력하세요");
            //string height = ReadLine();

            //double area = Convert.ToDouble(width) * Convert.ToDouble(height);

            //WriteLine(area.ToString());

            ////연습문제 5번 
            //var a = 2020;  //->Int32
            //WriteLine(a.GetType());
            //var b = "double"; //->String
            //WriteLine(b.GetType());



        }
    }
}
