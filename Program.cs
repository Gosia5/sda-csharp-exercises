using System;

namespace sda_csharp_exercises
{
    class Program
    {
        public static void Zamiana(string tekst)
        {
            char[] leetLetters = { '4', '3', '1', '0', '$' };
            char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };

            string newTekst = tekst;
            for(int i = 0; i < leetLetters.Length; i++)
            { newTekst = newTekst.Replace(naturalLetters[i], leetLetters[i]); }
            Console.WriteLine(newTekst);
        }
    }
}
