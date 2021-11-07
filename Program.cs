using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(int[] args)
        {
            int[] numbers = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1 };
            string PESEL = Console.ReadLine();
        }
        static bool checkPesel(int[] numbers, string PESEL)
        {
            int[] id = new int[PESEL.Length];
            int sum = 0;
            for (int i = 0; i < PESEL.Length -1; i++)
            {
                sum += numbers[i] * id[i];
            }
            int s = sum % 10;
            if(s == 0)
                return 0
                 
        }
    }
}
