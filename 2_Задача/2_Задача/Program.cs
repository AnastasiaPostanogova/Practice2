using System;

namespace Задача_2
{
    class Program
    {
        static void Main()
        {
            Int64 Types = Int64.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            int[] Animals = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                Animals[i] = int.Parse(numbers[i]);
            }

            Int64[] combo = new Int64[3];
            if (Types > 2)
            {
                for (int index = 0; index < Types; index++)
                {
                    combo[2] = combo[2] + combo[1] * Animals[index];
                    combo[1] = combo[1] + combo[0] * Animals[index];
                    combo[0] = combo[0] + Animals[index];
                }
            }
            Console.WriteLine(combo[2]);
        }
    }
}