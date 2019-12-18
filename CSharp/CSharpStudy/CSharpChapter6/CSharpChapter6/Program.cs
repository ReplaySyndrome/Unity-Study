using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChapter6
{
    class Program
    {
        static double Square(double arg)
        {
            //메소드를 구현해주세요
            return arg * arg;
        }

        static void Mean(double a, double b, double c, double d, double e, ref double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }

        public static void Plus(int a, int b, out int c)
        {
            c = a + b;
        }
        public static void Plus(double a, double b, out double c)
        {
            c = a + b;
        }
        static void Main(string[] args)
        {
            ////1.Square 메소드 구현하기
            //Console.WriteLine("수를 입력하세요:");
            //string input = Console.ReadLine();
            //double arg = double.Parse(input);

            //Console.WriteLine("결과: {0}", Square(arg));

            ////2. mean이 0을 갖는 원인과 이를 바로잡는 방법
            //double mean = 0;
            //Mean(1, 2, 3, 4, 5, ref mean);

            //Console.WriteLine("평균 : {0}", mean);
            //// ref 키워드를 이용하여 원본을 바꾸겠다고 명시한다
            ///

            ////3.Plus 메소드가 double형 메소드를 지원하도록 오버로딩 하세요
            //int a = 3;
            //int b = 4;
            //int resultA = 0;
            //Plus(a, b, out resultA);

            //Console.WriteLine("{0} + {1} = {2}", a, b, resultA);

            //double x = 2.4;
            //double y = 3.1;
            //double resultB = 0;
            //Plus(x, y, out resultB);

            //Console.WriteLine("{0} + {1} = {2}", x, y, resultB);
        }
    }
}
