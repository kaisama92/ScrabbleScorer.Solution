using System;
using System.Collections.Generic;

namespace ScrabbleScorer.Models
{
  public class ScrabbleScore
  {
    public char[] InputWord {get;set;}
    public Dictionary<int, string> scoreChart = new Dictionary<int, string>() {{1 , "AEIOULNRST"}, {2, "DG"}, {3, "BCMP"}, {4, "FHVWY"}, {5, "K"}, {8, "JX"}, {10, "QZ"}};
    public int Score {get;set;}

  
    public ScrabbleScore(string inputWord)
    {
      InputWord = inputWord.ToUpper().ToCharArray();
      Score = 0;
    }


    public int GetScore()
    {
      foreach (char letter in InputWord)
      {
        foreach (KeyValuePair<int, string> scorePair in scoreChart)
        {
          if (scorePair.Value.Contains(letter))
          {
            Score += scorePair.Key;
          }
        }
      }
      return Score;
    }
  }
}