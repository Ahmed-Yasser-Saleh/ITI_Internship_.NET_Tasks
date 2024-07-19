using System;
using System.Diagnostics.CodeAnalysis;

namespace task_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num of rows in 2D_ array");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num of columns in 2D_ array");
            int col = int.Parse(Console.ReadLine());
            int[ , ] arr = new int[row,col];
            int sum;
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    arr[i,j] = int.Parse(Console.ReadLine());
                }    
            }
            for (int i = 0; i < col; i++)
            {
                sum = 0;
                for (int j = 0; j < row; j++)
                {
                    sum += arr[j, i];
                }
                Console.WriteLine((float)sum / col);
            }
        }
    }

}
