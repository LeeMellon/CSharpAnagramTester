using System.Collections.Generic;
using System;


namespace Anagrams.Models
{
    public class Anagram
    {
      private string _baseWord;
      private List<string> _comparisonWords;

      // public Anagram(string baseWord, List<string> comparisonWords)
      // {
      //   _baseWord = baseWord;
      //   _comparisonWords = comparisonWords;
      // }

      public void SetBaseWord(string newBaseWord)
      {
        _baseWord = newBaseWord;
      }

      public string GetBaseWord()
      {
        return _baseWord;
      }

      public List<string> SetComparisonWords(List<string> newComparisonWords)
      {
        _comparisonWords = newComparisonWords;
        return _comparisonWords;
      }

      public List<string> GetComparisonWords()
      {
        return _comparisonWords;
      }

      public char[] BaseToArray(string baseWord)
      {
        char[] BaseWordArray = baseWord.ToCharArray();
        return BaseWordArray;
      }

      public char[] BaseToLowerArray(string baseWord)
      {
        char[] BaseWordArray = baseWord.ToLower().ToCharArray();
        return BaseWordArray;
      }

      public char[] SortBaseArray(string baseWord)
      {
        char[] BaseWordArray = baseWord.ToLower().ToCharArray();
        Array.Sort(BaseWordArray);
        return BaseWordArray;
      }
    }

}
