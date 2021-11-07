using System;

namespace sda_csharp_exercises
{
    class Program
    {
        public static void PrintUniqueNumbers(int[] numbersArray)
        {
            for (int i = 0; i < numbersArray.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (numbersArray[i] == numbersArray[j])
                    {
                        isDuplicate = true;
                    }
                }

                if (!isDuplicate)
                {
                    Console.WriteLine(numbersArray[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 2, 2, 1, 2, 5, 1, 2, 5, 1 };
            PrintUniqueNumbers(numbers);
        }    
    }
}
