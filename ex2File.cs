using System;

namespace Exercise8_2
{
    class Program
    {
        // переворачивает строку
        static string Reverse(string text)
        {
            string result = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                result += text[i];
            }

            return result;
        }

        static void Main()
        {
            Console.WriteLine(Reverse("Данис"));
            Console.WriteLine(Reverse("Привет, Мир"));
            Console.WriteLine(Reverse("123456789"));
            Console.WriteLine(Reverse("леша на полке клопа нашел"));
        }
    }
}