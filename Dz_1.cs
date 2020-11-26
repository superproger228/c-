using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            string set = Console.ReadLine();
            string poli = "";
            foreach (char c in set)
            {
                if (char.IsLetter(c) || char.IsDigit(c))
                {
                    poli += char.ToLower(c);
                }
            }
            bool isPalindrom = true;
            for (int i = 0; i < poli.Length / 2; i++)
            {
                if (poli[i] != poli[poli.Length - i - 1])
                {
                    isPalindrom = false;
                }
            }

            Console.Write($"\"{set}\" is ");
            Console.WriteLine(isPalindrom
            ? "палиндром"
            : "не палиндром");
        }
    }
}
