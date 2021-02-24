using System;

namespace TGS.Challenge
{
    /*
        Devise a function that takes an input 'n' (integer) and returns a string that is the
        decimal representation of that number grouped by commas after every 3 digits. 
        
        NOTES: You cannot use any built-in formatting functions to complete this task.

        Assume: 0 <= n < 1000000000

        1 -> "1"
        10 -> "10"
        100 -> "100"
        1000 -> "1,000"
        10000 -> "10,000"
        100000 -> "100,000"
        1000000 -> "1,000,000"
        35235235 -> "35,235,235"

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class FormatNumber
    {
        public string Format(int value)
        {
            //Check if value is greater than 1000000000 or smaller than 0, then throw ArgumentOutOfRangeException
            if (value < 0 || value > 1000000000)
                throw new ArgumentOutOfRangeException();

            System.Text.StringBuilder builder = new System.Text.StringBuilder(value.ToString());
            //if length is greater than 3 then we add comma
            if (builder.Length > 3)
            {
                var reminder = builder.Length % 3;
                var quotient = builder.Length / 3;
                var noOfCommasInserted = 0;

                /* Insert the first comma at index = reminder if reminder is greater than 0 
                  and increament the value of noOfCommasInserted by 1 */
                if (reminder > 0)
                {
                    builder.Insert(reminder, ',');
                    noOfCommasInserted++;
                }

                /*insert comma after 3 digit from last comma
                  and increament the value of noOfCommasInserted by 1 */
                for (int i = 1; i < quotient; i++)
                {
                    reminder = reminder + noOfCommasInserted + 3;
                    builder.Insert(reminder, ',');
                    noOfCommasInserted++;
                }
            }

            return builder.ToString();
        }
    }
}
