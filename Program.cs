using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba = Convert.ToInt32(Console.ReadLine());
        }
        static int silnia(int liczba)
        {
            if(liczba < 0)
            {
                throw new ArgumentException("Błąd.");
            }
            int wynik = 1;
            for (int i = liczba; i <= 1; i++)
            {
                wynik *= i;
            }
            return liczba * wynik;
        }
    }
}
   
