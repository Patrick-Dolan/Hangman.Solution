using System.Collections.Generic;

namespace Hangman.Models
{
  public class HangmanWord
  {
    public static List<string> wordList = new List<string> { "Wordle", "Ghost", "Arose", "Geared" };
    public string Solution { get; }

    public HangmanWord()
    {
      Solution = wordList[0];
    }
  }
}