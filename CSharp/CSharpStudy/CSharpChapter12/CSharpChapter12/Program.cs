using System;

namespace CSharpChapter12
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 다음 코드에서 예외를 안전하게 잡아 처리하도록 코드를 수정하세요. 
            int[] arr = new int[10];

            for(int i=0;i<10;++i)
            {
                arr[i] = i;
            }

            try 
            {
                for (int i = 0; i < 11; ++i)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch ( IndexOutOfRangeException e)
            {
                Console.WriteLine("처리되지 않은 예외 : " +  e.ToString() + e.Message );
            }
            

        }
    }
}
