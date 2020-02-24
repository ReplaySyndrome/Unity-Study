using System;
using System.Collections;
using System.Collections.Generic;
namespace CSharpChaper11
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1.다음 코드에서 원인을 찾으세요
            //Queue queue = new Queue();
            //queue.Enqueue(10);
            //queue.Enqueue("한글");
            //queue.Enqueue(3.14);

            //Queue<int> queue2 = new Queue<int>();
            //queue2.Enqueue(10);
            //queue2.Enqueue("한글");
            //queue2.Enqueue(3.14);

            ////Queue2는 int형태로 한정지었기 때문에 string타입이나 float타입은 집어넣을 수 없다.
            //


            ////2.다음 코드에서 1)에 들어갈 내용은?
            //Dictionary<string, string> dic = new Dictionary<string, string>();
            //dic["하나"] = "one";
            //dic["둘"] = "two";
            //dic["셋"] = "three";
            //dic["넷"] = "four";
            //dic["다섯"] = "five";

            //Console.WriteLine(dic["하나"]);
            //Console.WriteLine(dic["둘"]);
            //Console.WriteLine(dic["셋"]);
            //Console.WriteLine(dic["넷"]);
            //Console.WriteLine(dic["다섯"]);

            ////정답: string, string
        }
    }
}
