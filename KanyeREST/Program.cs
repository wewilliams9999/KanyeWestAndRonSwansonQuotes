using Newtonsoft.Json.Linq; //NuGet package that allows us to work with JSON
using System;
using System.Net.Http;

namespace KanyeREST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*~~~~~~~~~Kanye West and Ron Swanson quotes~~~~~~~~~*");

            for (int i = 0; i < 6; i++)
            {
                QuoteGenerator.KanyeQuote();

                QuoteGenerator.RonQuote();

                Console.WriteLine("---------------------------------");
                Console.WriteLine("Which quote do you prefer? Type K for Kanye or R for Ron");
                var response = Console.ReadLine();
                if (response.ToLower() == "k")
                {
                    Console.WriteLine("Yeah, Kanye is the greatest.");
                }
                else if (response.ToLower() == "r")
                {
                    Console.WriteLine("Ron is hilarious");
                }
                else Console.WriteLine("Hmmm....whatever you say");
                Console.WriteLine("---------------------------------");
            }

            Console.WriteLine("Thanks for playing along!");



        }
    }
}
