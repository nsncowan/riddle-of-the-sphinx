using System;
using System.Collections.Generic;
using System.Linq;

class Riddle
{

  // getRandomRiddle()
  // {
  // // Random rand = new Random();
  // // dictTest = dictTest.OrderBy(x => rand.Next())
  // //             .ToDictionary(item => item.Key, item => item.Value);

  // var rnd = new Random();
  // var randomEntry = riddleDictionary.ElementAt(rnd.Next(0, riddleDictionary.Count));
  // String randomKey = randomEntry.Key;
  // String randomValue = randomEntry.Value;
  // }
  
  
  static void Main()
  {
  Dictionary<string, string> riddleDictionary = new Dictionary<string, string>()
  {
    {"I am always hungry, I must always be fed, the finger I touch, will soon turn red. What am I?", "Fire"},
    {"I am an odd number. Take away a letter and I become even. What am I?", "Seven"},
    {"I am tall when young and short when old. What am I?", "Candle"},
    {"I am always in front of you but you cannot touch me. What am I?", "The Future"},
    {"I am light as a feather, yet the strongest person can't hold me for much more than a minute. What am I?", "Breath"},
  };


    var rnd = new Random();
    var randomEntry = riddleDictionary.ElementAt(rnd.Next(0, riddleDictionary.Count));
    String randomKey = randomEntry.Key;
    String randomValue = randomEntry.Value;
    Console.WriteLine(randomKey);
    string answer = Console.ReadLine();
    if (answer == randomValue)
    {
      Console.WriteLine("you are correct!");
      var rnd2 = new Random();
      var randomEntry2 = riddleDictionary.ElementAt(rnd2.Next(0, riddleDictionary.Count));
      String randomKey2 = randomEntry2.Key;
      String randomValue2 = randomEntry2.Value;
      Console.WriteLine(randomKey2);
      string answer2 = Console.ReadLine();
        if (answer2 == randomValue2)
        {
            Console.WriteLine("you are correct! I won't eat you");
        } 
        else 
        {
            Console.WriteLine("I'm gonna eat you");
        }
    }
    else
    {
      Console.WriteLine("try again!");
    }

  }
}