using System;

namespace Methodzzzzzzzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string word = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = (Console.ReadLine());
            Console.WriteLine($"{word} is a {color} person who thinks that {band} is a bunch of disguised {animal}s.");

        }
    }
}
