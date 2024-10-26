using System;

namespace _4.week_CODERBYTE_LetterCapatilize
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(LetterCapitalize(Console.ReadLine()));

            Console.ReadKey();
        }

        public static string LetterCapitalize(string str)
        {
            string result = "";
            bool newWord = true;

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if (c == ' ') // Boşluk karakterini bulursak
                {
                    newWord = true;
                    result += c; // Boşlukları ekle
                }
                else
                {
                    if (newWord)
                    {
                        result += char.ToUpper(c); // İlk harfi büyük yap
                        newWord = false;
                    }
                    else
                    {
                        result += c; // Diğer harfleri olduğu gibi ekle
                    }
                }
            }

            return result;
        }
    }
}
