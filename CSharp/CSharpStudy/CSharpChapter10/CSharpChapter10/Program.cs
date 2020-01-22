using System;
using System.Collections;
namespace CSharpChapter10
{
    class Program
    {
        public static int[,] MatrixMul(int[,] arr1, int[,] arr2)
        {
            return new int[2, 2] { { arr1[0,0] * arr2[0,0] + arr1[0,1] * arr2[1,0], arr1[0,0]*arr2[0,1] + arr1[1,0]*arr2[1,1] },
                { arr1[1,1] * arr2[0,0] + arr1[1,1] * arr2[1,0], arr1[1,1] * arr2[0,1] + arr1[1,1] * arr2[1,1] } };
        }
        static void Main(string[] args)
        {
            // 1. 다음 배열 선언 문장 중 올자르지 않은 것을 고르시오.
            // 1) int[] array = new string[3] { "안녕", "Hello", "Halo" } -> int형식의 배열에 string을 할당할 수 없다.
            // 2) int[] array = new int[3] {1,2,3}
            // 3) int[] array = new int[]{1,2,3}
            // 4) int[] array = {1,2,3}

            // 2. 두 행렬의 곱을 2차원 배열을 이용하여 계산하는 프로그램을 작성하세요.

            //int[,] A = new int[2, 2] { { 3, 2 }, { 1, 4 } };
            //int[,] B = new int[2, 2] { { 9, 2 }, { 1, 7 } };
            //int[,] sum = MatrixMul(A, B);
            //foreach( int arr in sum)
            //{
            //    Console.WriteLine(arr);
            //}

            // 3. 다음 코드의 출력결과는?
            //Stack stack = new Stack();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            //while(stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //} -> 5,4,3,2,1

            //4. 다음 코드의 출력 결과는 무엇일까요?
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //while(queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //} -> 1,2,3,4,5

            //5. 코드를 완성하시오
            //Hashtable hashtable = new Hashtable();
            //hashtable["회사"] = "Microsoft";
            //hashtable["URL"] = "www.microsoft.com";
            //Console.WriteLine("회사 : {0}", hashtable["회사"]);
            //Console.WriteLine("URL : {0}", hashtable["URL"]);

        }
    }
}
