using System;

namespace HelloYou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what are you?"); 
            
            var you = Console.ReadLine();


            Console.WriteLine($"Hello, {you}");

            Console.WriteLine("What year is it?");

            var year = int.Parse(Console.ReadLine());


            Console.WriteLine($"Hello {you} in the year of {year}");
        
        }
    }
}
