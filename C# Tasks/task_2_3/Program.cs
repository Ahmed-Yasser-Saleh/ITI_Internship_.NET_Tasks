using System;

namespace task_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 6;
            rep(ref x, ref y);
            Console.WriteLine($"{x} - {y}");
        }
        static void rep(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;  
            y = temp;
        }
    }
}
