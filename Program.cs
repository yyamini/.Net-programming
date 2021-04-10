using System;
using System.Collections.Generic;

namespace GenericDictionary
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Dictionary<string, string> movie = new Dictionary<string, string>();


            movie.Add("sci-fi", "Star Wars");
            movie.Add("Action", "The One");
            movie.Add("Fantacy", "Star Dust");
            movie.Add("Computer", "Algorithm");
            movie.Add("Love", "50 First Dates");

            Console.WriteLine(movie["sci-fi"]);

            foreach (KeyValuePair<string, string> items in movie)
            {
                Console.WriteLine(items.ToString());
            }


            if (movie.ContainsKey("sci-fi"))
            {
                Console.WriteLine("Key found. Value is " + movie["sci-fi"]);
            }
            else
            {
                Console.WriteLine("Key Not Found");
            }
        }
    }
}