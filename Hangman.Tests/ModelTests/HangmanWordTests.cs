using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman.Models;

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
  }
}