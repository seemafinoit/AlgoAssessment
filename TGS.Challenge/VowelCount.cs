using System;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class VowelCount
    {
        public int Count(string value)
        {
            //Check if value is null or empty then throw ArgumentException
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException();

            int i, len, vowel;

            vowel = 0;
            len = value.Length; // length of value

            //convert the value in lower case
            value = value.ToLower();

            //loop each character
            for (i = 0; i < len; i++)
            {
                // check if character is equal to 'a', 'e', 'i', 'o', 'u'
                if (value[i] == 'a' || value[i] == 'e' || value[i] == 'i' || value[i] == 'o' || value[i] == 'u')
                {
                    vowel++;
                }
            }

            return vowel;
        }
    }
}
