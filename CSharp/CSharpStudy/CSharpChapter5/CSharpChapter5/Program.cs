using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.별찍기
            //
            //*
            //**
            //***
            //****
            //*****
            //for (int i=0;i<5;++i)
            //{

            //    for( int j=0;j<5;++j)
            //    {
            //        if(i>=j)
            //        {                        
            //            Console.Write("*");
            //        }
            //    }
            //    Console.Write('\n');
            //}


            //2. 별찍기
            //*****
            //****
            //***
            //**
            //*
            //for (int i = 0; i < 5; ++i)
            //{
            //    for (int j = 0; j < 5; ++j)
            //    {
            //        if (j >= i)
            //        {
            //            Console.Write("*");
            //        }

            //    }
            //    Console.WriteLine();
            //}


            ////3. 1번과 2번을 while문과 do문으로 바꾸어라
            //int i = 0;
            //while(i++<5)
            //{
            //    int j = 0;
            //    while(j++ < 5)
            //    {
            //        if (j<=i)
            //        {
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //i = 0;

            //while (i++ < 5)
            //{
            //    int j = 0;
            //    while (j++ < 5)
            //    {
            //        if (j >= i)
            //        {
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();
            //}


            //4. 사용자로부터 입력받은 횟수만큼 별을 반복 출력하는 프로그램을 작성하시오.
            //단 입력받은 수가 0보다 작거나 같으면 오류메세지를 띄우고 프로그램을 종료합니다.

            Console.WriteLine("반복 횟수를 입력하세요:");
            string a = Console.ReadLine();
            int b = int.Parse(a);

            if (b <= 0 )
            {
                Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
            }
            else
            {
                for (int i = 0; i < b; ++i)
                {

                    for (int j = 0; j < b; ++j)
                    {
                        if (i >= j)
                        {
                            Console.Write("*");
                        }
                    }
                    Console.Write('\n');
                }
            }

        }
    }
}
