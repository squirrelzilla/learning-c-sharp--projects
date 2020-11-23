using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program creates a MadLibs type of interaction.
      Author: Aaron Squirrelzilla
      */

      // Let the user know that the program is starting:
      Console.Write("Standby for a fun MadLibs time! \n \n");

      // Give the Mad Lib a title:
      string title = "Going Mad with MadLibs! \n";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.Write("Enter a name: ");
      string name = Console.ReadLine();

      Console.Write("\n");
      Console.Write($"Thank you {name}! You're going to be asked for three adjectives.. \n \n");

      Console.Write("Please enter your first adjective: ");
      string adjectiveOne = Console.ReadLine();

      Console.Write("Please enter your second adjective: ");
      string adjectiveTwo = Console.ReadLine();

      Console.Write("Please enter your third adjective: ");
      string adjectiveThree = Console.ReadLine();

      Console.Write("\n");
      Console.Write("Now you're going to be asked for three verbs! \n \n");

      Console.Write("Please enter your first verb: ");
      string verbOne = Console.ReadLine();

      Console.Write("Please enter your second verb: ");
      string verbTwo = Console.ReadLine();

      Console.Write("Please enter your third verb: ");
      string verbThree = Console.ReadLine();

      Console.Write("\n");
      Console.Write("Now you're going to be asked to provide two nouns. \n \n");

      Console.Write("Please enter your first noun: ");
      string nounOne = Console.ReadLine();

      Console.Write("Please enter your second noun: ");
      string nounTwo = Console.ReadLine();
      
      Console.Write("\n");
      Console.Write("Now it's about to get fun AND interesting! \n");

      Console.Write("Please enter an animal: ");
      string animal = Console.ReadLine();

      Console.Write("Please enter a food item: ");
      string food = Console.ReadLine();

      Console.Write("Please enter a fruit: ");
      string fruit = Console.ReadLine();

      Console.Write("Please name a superhero: ");
      string superhero = Console.ReadLine();

      Console.Write("Please enter the name of a country: ");
      string country = Console.ReadLine();

      Console.Write("Please enter the name of a dessert: ");
      string dessert = Console.ReadLine();

      Console.Write("Please enter a four-digit year: ");
      string year = Console.ReadLine();

      // The template for the story:
      string story = $"This morning {name} woke up feeling {adjectiveOne}. 'It is going to be a {adjectiveTwo} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verbOne} to the rhythm of the {nounOne}, which made all the {fruit}s very {adjectiveThree}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";

      // Print the story:
      Console.Write("\n");
      Console.WriteLine(story);
    }
  }
}
