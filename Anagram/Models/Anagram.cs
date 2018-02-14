using System.Collections.Generic;
using System;
using System.Linq;


namespace Anagrams.Models
{
    public class Anagram
    {
      private char[] _baseWord;
      private List<char[]> _comparisonWords;

      public void SetBaseWord(char[] newBaseWord)
      {
        _baseWord = newBaseWord;
      }

      public char[] GetBaseWord()
      {
        return _baseWord;
      }

      public List<char[]> GetComparisonWords()
      {
        return _comparisonWords;
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
          if (baseWord.SequenceEqual(ComparisonWords[x]))
          {
            ActualAnagrams.Add(OriginalWords[x]);
          }
        }
        return ActualAnagrams;
      }

    }

}
