using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagrams.Models;
using System;

namespace Anagrams.Tests
{
  [TestClass]
  public class AnagramTest
  {
    // public void Dispose()
    // {
    //     Anagram.ClearAll();
    // }

    [TestMethod]
    public void  BaseToArray_MakeArray_False()
    {
      Anagram testMonkey = new Anagram();
      testMonkey.SetBaseWord("Turkey");
      string testOutput = testMonkey.GetBaseWord();
      Assert.AreEqual(false, testOutput);
    }
    [TestMethod]
    public void  BaseToArray_MakeArray_True()
    {
      string TestTurkey = "Turkey";
      char[] TurkArray = TestTurkey.ToCharArray();
      Anagram testMonkey = new Anagram();
      char[] testOutput = testMonkey.BaseToArray("Turkey");
      CollectionAssert.AreEqual(TurkArray, testOutput);
    }
    // [TestMethod]
    // public void IsDivThree_DivisableBy_False()
    // {
    //   int Testint = 2;
    //   PingPong testPong = new PingPong();
    //   Assert.AreEqual(false, testPong.IsDiv(Testint));
    // }
    //

  }
}
