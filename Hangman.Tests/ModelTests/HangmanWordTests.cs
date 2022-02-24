using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Hangman.Tests
{
  [TestClass]
  public class HangmanWordTests
  {
    [TestMethod]
    public void HangmanWordConstructor_CreatesHangmanWordObject_HangmanWord()
    {
      HangmanWord newHangmanWord = new HangmanWord();
      Assert.AreEqual(typeof(HangmanWord), newHangmanWord.GetType());
    }

    [TestMethod]
    public void GetWord_FetchsAWordFromWordList_String()
    {
      HangmanWord newHangmanWord = new HangmanWord();
      List<string> wordList = new List<string> { "Wordle", "Ghost", "Arose", "Geared" };
      bool result = true;
      Assert.AreEqual(wordList.Contains(newHangmanWord.Solution), result);
    }

    [TestMethod]
    public void GetWord_FetchsARandomWordFromWordList_String()
    {
      List<string> wordList = new List<string> { "Wordle", "Ghost", "Arose", "Geared" };
      HashSet<string> set = new HashSet<string>();
      for (int i = 0; i < 1000; i++)
      {
        HangmanWord newHangmanWord = new HangmanWord();
        string solution = newHangmanWord.GetWord();
        Console.WriteLine(solution);
        set.Add(solution);
      }
      List<string> result = set.ToList();
      result.Sort();
      wordList.Sort();
      CollectionAssert.AreEqual(result, wordList);
    }
  }
}