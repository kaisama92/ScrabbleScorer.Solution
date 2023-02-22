using System;
using ScrabbleScorer.Models;
using System.Runtime;

namespace ScrabbleScorer
{
  class Program
  {

    static void Main()
    {
      try
      {
        Console.WriteLine("Enter a word to get the equivelent scrabble score!");
        string userInput = Console.ReadLine();
        string[] stringArr = userInput.Split(" ");
        if (stringArr.Length > 1)
        {
          throw new ArgumentException("Only Enter ONE Word");
        }
        ScrabbleScore word = new ScrabbleScore(userInput);
        word.GetScore();
        Console.WriteLine(word.Score);
        Program.Main();
      }
      catch (ArgumentException e)
      {
        Console.WriteLine(e);
        Program.Main();
      }
    }
  }
}

