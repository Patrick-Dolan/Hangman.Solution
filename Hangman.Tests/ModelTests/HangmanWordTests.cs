using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman.Models;
using System.Collections.Generic;

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
  }
}