using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            //int val = 5;
            //int row, col, k;
            //for (row = val; row >= 0; row--)
            //{
            //    for (col = 1; col <= row; col++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

             
            //Console.ReadLine();


            //int[] runningNum = new int[20];
            //for (int i = runningNum.Length;i>=0; i--)
            //{

            //    Console.WriteLine(i);
            //}

            fibonacci(10);


            Console.ReadLine();

    }

        public static void fibonacci(int n)
        {
            int firstNum = 0;
            int secondNum = 1;
            int result = 0;

            Console.WriteLine($"{firstNum}\n{secondNum}");

            for (int i = 2; i <= n; i++)
            {
                result = firstNum + secondNum;
                Console.WriteLine($"{result}");
                firstNum = secondNum;
                secondNum = result;
            }

            
        }
    }
}
