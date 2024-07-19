using System;
using System.Linq;

namespace task_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size, sum = 0;
            size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++) arr[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++) sum += arr[i];
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Max());
            Console.WriteLine(sum);
        }
    }
}
