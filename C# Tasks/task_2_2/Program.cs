using System;

namespace task_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            do
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
            } while (sum <= 100 && num != 0);
            Console.WriteLine($"sum of nums:{sum}");
        }
    }
}
