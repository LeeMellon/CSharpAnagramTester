using System.Collections.Generic;
using System;


namespace Anagrams.Models
{
    public class Anagram
    {
      private string _baseWord;
      private List<char[]> _comparisonWords;

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

      public List<char[]> SetComparisonWords(List<string> ComparisonWords)
      {
        List<char[]> newComparisonWords = new List<char[]>();
        foreach(string word in ComparisonWords){
          char[] cleanedWord = word.ToLower().ToCharArray();
          Array.Sort(cleanedWord);
          newComparisonWords.Add(cleanedWord);
        }
          _comparisonWords = newComparisonWords;
          return _comparisonWords;
       }

      public List<char[]> GetComparisonWords()
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
