using System;

namespace Ex2
{
    internal class Program
    {
        private static void Search()
        {
            string str;
            string word;
            int count = 0;
            Console.WriteLine("Enter a string ");
            str = Console.ReadLine();
            Console.WriteLine("Enter a word to search ");
            word = Console.ReadLine();
            string[] c = str.Split();
            for (int i = 0; i < c.Length; i++)
            {
                if (word != null && word.Equals(c[i]))
                {
                    count++;
                }
            }

            if (count <= 1)
            {
                Console.WriteLine($"Word found {count} time in the string");
            }
            else
            {
                Console.WriteLine($"Word found {count} times in the string");
            }
        }

        public static void Main(string[] args)
        {
            Search();
        }
    }
}
