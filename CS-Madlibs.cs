//C# Madlibs
using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program is a form of Mad Libs
            Author: Me
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Let us begin...");

            // Give the Mad Lib a title:
            string title = "A tale of a Soft Kitty";
            Console.WriteLine(title);
            // Define user input and variables:

            //main character
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            //first adjective
            Console.Write("Describe a texture: ");
            string texture = Console.ReadLine();
            //second adjective
            Console.Write("Enter an adjective describing the weather: ");
            string weather = Console.ReadLine();
            //third adjective
            Console.Write("Describe a feeling: ");
            string feeling = Console.ReadLine();
            //verb
            Console.Write("Enter a movement: ");
            string movement = Console.ReadLine();
            //first noun
            Console.Write("Enter an instrument: ");
            string instrument = Console.ReadLine();
            //second noun
            Console.Write("Enter a a kitchen appliance: ");
            string appliance = Console.ReadLine();
            //animal
            Console.Write("Enter an animal: ");
            string animal = Console.ReadLine();
            //food
            Console.Write("Enter a food type: ");
            string food = Console.ReadLine();
            //fruit
            Console.Write("Enter a fruit type: ");
            string fruit = Console.ReadLine();
            //superhero
            Console.Write("Enter a superhero: ");
            string superhero = Console.ReadLine();
            //country
            Console.Write("Enter a country: ");
            string country = Console.ReadLine();
            //dessert
            Console.Write("Enter a dessert type: ");
            string dessert = Console.ReadLine();
            //year
            Console.Write("Enter a year: ");
            string year = Console.ReadLine();
            // The template for the story:

            string story = $"This morning {name} woke up feeling {texture}. 'It is going to be a {weather} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {movement} to the rhythm of the {instrument}, which made all the {fruit}s very {feeling}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {appliance}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);
        }
    }
}