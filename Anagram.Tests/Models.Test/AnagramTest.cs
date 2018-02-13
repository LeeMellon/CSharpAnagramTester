using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagrams.Models;
using System;

namespace Anagrams.Tests
{
  [TestClass]
  public class AnagramTest
  {


    [TestMethod]
    public void  BaseToArray_CompareWord_True()
    {
      Anagram testMonkey = new Anagram();
      testMonkey.SetBaseWord("Turkey");
      string testOutput = testMonkey.GetBaseWord();
      Assert.AreEqual("Turkey", testOutput);
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

    [TestMethod]
    public void  BaseToLowerArray_MakeArrayLower_True()
    {
      string TestTurkey2 = "turkey";
      char[] TurkArray2 = TestTurkey2.ToCharArray();
      Anagram testMonkey2 = new Anagram();
      char[] testOutput2 = testMonkey2.BaseToLowerArray("TURKEy");
      CollectionAssert.AreEqual(TurkArray2, testOutput2);
    }
    [TestMethod]
    public void  SortBaseArray_BaseSorted_False()
    {
      string TestFerret = "ferret";
      char[] FerretArray = TestFerret.ToCharArray();
      Anagram testMonkey3 = new Anagram();
      char[] testOutput3 = testMonkey3.SortBaseArray("TURKEy");
      CollectionAssert.AreEqual(FerretArray, testOutput3);
    }
    [TestMethod]
    public void  SortBaseArray_BaseSorted_True()
    {
      string TestFerret2 = "eefrrt";
      char[] FerretArray2 = TestFerret2.ToCharArray();
      Anagram testMonkey4 = new Anagram();
      char[] testOutput4 = testMonkey4.SortBaseArray("FERRET");
      CollectionAssert.AreEqual(FerretArray2, testOutput4);
    }
  }
}
