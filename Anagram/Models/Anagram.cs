using System.Collections.Generic;
using System;
using System.Linq;


namespace Anagrams.Models
{
    public class Anagram
    {
      private char[] _baseWord;
      private List<char[]> _comparisonWords;

      // public Anagram(string baseWord, List<string> comparisonWords)
      // {
      //   _baseWord = baseWord;
      //   _comparisonWords = comparisonWords;
      // }

      public void SetBaseWord(char[] newBaseWord)
      {
        _baseWord = newBaseWord;
      }

      public char[] GetBaseWord()
      {
        return _baseWord;
      }

      public List<char[]> SetComparisonWords(List<string> ComparisonWords)
      {
        List<char[]> newComparisonWords = new List<char[]>();
        foreach(string word in ComparisonWords)
        {
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
      //
      // public char[] BaseToArray(string baseWord)
      // {
      //   char[] BaseWordArray = baseWord.ToCharArray();
      //   return BaseWordArray;
      // }
      //
      // public char[] BaseToLowerArray(string baseWord)
      // {
      //   char[] BaseWordArray = baseWord.ToLower().ToCharArray();
      //   return BaseWordArray;
      // }

      public char[] SetBaseArray(string baseWord)
      {
        char[] BaseWordArray = baseWord.ToLower().ToCharArray();
        Array.Sort(BaseWordArray);
        _baseWord = BaseWordArray;
        return _baseWord;
      }

      public List<string> TestAnagram(char[] baseWord, List<char[]> ComparisonWords, List<string> OriginalWords)
      {
        List<string> ActualAnagrams = new List<string>();
        for (int x = 0; x < ComparisonWords.Count; x++)
        {
          Console.WriteLine(ComparisonWords[x]);
          if (baseWord.SequenceEqual(ComparisonWords[x]))
          {
            Console.WriteLine("here2");
            ActualAnagrams.Add(OriginalWords[x]);
          }
        }
        return ActualAnagrams;
      }

    }

}
