using System;
using System.Collections.Generic;

namespace Hangman.Models
{
  public class HangmanWord
  {
    public static List<string> wordList = new List<string> { "Wordle", "Ghost", "Arose", "Geared" };
    public string Solution { get; }

    public HangmanWord()
    {
      Solution = this.GetWord();
    }

    public string GetWord()
    {
      Random random = new Random();
      int number = random.Next(0, wordList.Count);
      string result = wordList[number];
      return result;
    }
  }
}