using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      // intro
      Console.WriteLine("Welcome to Money Maker!");
      
      // requests input from the user
      Console.WriteLine("\n");
      Console.WriteLine("Enter a whole number amount, in cents, to tell you the most efficient way to get there! ");
      
      // takes input and stores variable
      string totalAsString = Console.ReadLine();
      double coins = Convert.ToDouble(totalAsString);

      // let's the user know what's about to happen
      Console.WriteLine("\n");
      Console.WriteLine($"{coins} cents is equal to...");

      // coin values
      int quarterValue = 25;
      int dimeValue = 10;
      int nickelValue = 5;

      // quarters computation
      double quarterCoins = Math.Floor(coins / quarterValue);
      double remainder = coins % quarterValue;

      // dimes computation
      double dimeCoins = Math.Floor(remainder / dimeValue);
      remainder = remainder % dimeValue;

      // nickels computation
      double nickelCoins = Math.Floor(remainder / nickelValue);
      remainder = remainder % nickelValue;

      // print out of results
      Console.WriteLine($"Quarters: {quarterCoins}");
      Console.WriteLine($"Dimes: {dimeCoins}");
      Console.WriteLine($"Nickels: {nickelCoins}");
      Console.WriteLine($"Pennies: {remainder}");
      // Console.WriteLine("\n");
      // Console.WriteLine($"{coins} cents is equal to...")

    }
  }
}
