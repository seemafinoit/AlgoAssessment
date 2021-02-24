using System;
using System.Text.RegularExpressions;

namespace TGS.Challenge
{
  /*
        Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
        one another return true, else return false

        "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
        phrase to produce a new word or phrase, using all the original letters exactly once; for example
        orchestra can be rearranged into carthorse.

        areAnagrams("horse", "shore") should return true
        areAnagrams("horse", "short") should return false

        NOTE: Punctuation, including spaces should be ignored, e.g.

        horse!! shore = true
        horse  !! shore = true
          horse? heroes = true

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class Anagram
    {
      public bool AreAnagrams(string word1, string word2)
      {
            //Check if word1 or word2 is null or empty then throw ArgumentException
            if (string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2))
                throw new ArgumentException();

            //size of array - 122 is ASCII value of z
            int NO_OF_CHARS = 122;

            //Replace all character by "", except a-z and 0-9
            word1 = Regex.Replace(word1.ToLower(), @"[^a-z0-9]", "");
            word2 = Regex.Replace(word2.ToLower(), @"[^a-z0-9]", "");

            int[] count1 = new int[NO_OF_CHARS];
            int[] count2 = new int[NO_OF_CHARS];

            //Count number of times a character occurs in word
            for (int i = 0; i < word1.Length && i < word2.Length; i++)
            {
                count1[word1[i]]++;
                count2[word2[i]]++;
            }

            //Compare the length of words            
            //if length is not equal, then return false
            if (word1.Length != word2.Length)
                return false;

            //Compare the value of array at each index
            //if it's not equal, then return false
            for (int i = 0; i < NO_OF_CHARS; i++)
                if (count1[i] != count2[i])
                    return false;

            return true;
        }
    }
}
