using System;
using System.Collections.Generic;

namespace Hangman.Models
{
  public class HangmanWord
  {
    public static List<string> wordList = new List<string> { "wordle", "ghost", "arose", "geared" };
    public string Solution { get; }

    public HangmanWord()
    {
      Solution = this.GetWord();
    }

    public string GetWord()
    {
      Random random = new Random();
      int number = random.Next(wordList.Count);
      string result = wordList[number];
      return result;
    }

    public bool CheckLetter(string guess)
    {
      return Solution.Contains(guess);
    }
  }
}