using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");

      // story start and choice 1
      Console.Write("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?\n");
      Console.Write("Type YES or NO: ");
      string noiseChoice = Console.ReadLine();
      noiseChoice = noiseChoice.ToUpper();
    
     if (noiseChoice == "NO")
     {
       Console.WriteLine("Not much of an adventure if we don't leave our room!");
       Console.WriteLine("THE END.");
     }
     // choice 2
     else if (noiseChoice == "YES")
     {
       Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?\n");
      Console.Write("Type OPEN or KNOCK: ");
      string doorChoice = Console.ReadLine();
      doorChoice = doorChoice.ToUpper();
      if (doorChoice == "KNOCK")
      {
        Console.Write("A voice behind the door speaks. It says, \"Answer this riddle:\" \"Poor people have it. Rich people need it. If you eat it you die. What is it?\"\n");
        Console.Write("Typer your answer: ");
        string riddleAnswer = Console.ReadLine();
        riddleAnswer = riddleAnswer.ToUpper();
        if (riddleAnswer == "NOTHING")
        {
          Console.Write("The door opens and NOTHING is there.\n");
          Console.Write("You turn off the light and run back to your room and lock the door.\n");
          Console.Write("THE END.\n");
        }
        else 
        {
          Console.WriteLine("You answered incorrectly. The door doesn't open.\n");
          Console.Write("THE END.\n");
        }
        }
        else if (doorChoice == "OPEN")
        {
          Console.WriteLine("The door is locked! See if one of your three keys will open it.\n");
          Console.Write("Enter a number (1-3):\n ");
          string keyChoice = Console.ReadLine();
          switch (keyChoice)
          {
            case "1":
             Console.WriteLine("You choose the first key. Lucky choice!\n");
             Console.WriteLine("The door opens and NOTHING is there. Strange...\n");
             Console.WriteLine("THE END.");
              break;
            case "2":
             Console.WriteLine("You choose the second key. The door doesn't open.\n");
             Console.WriteLine("THE END.");
              break;
            case "3":
              Console.WriteLine("You choose the third key. The door doesn't open.\n");
              Console.WriteLine("THE END.");
              break;
          }
        }
      }
     }

    }
  }
