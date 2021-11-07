using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Zamiana(string tekst)
        {
            char[] leetLetters = { '4', '3', '1', '0', '$' };
            char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };

            string nowy = tekst;
            for(int i = 0; i < leetLetters.Length; i++)
            { nowy = nowy.Replace(naturalLetters[i], leetLetters[i]); }
            Console.WriteLine(nowy);
        }
    }
}
