using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeIntoWords
{
    class BusinessLogic
    {
        public static string timeInWords(int h, int m)
        {
            // Variables
            // Declare possible strings for 1 - 19 (20 - 29 will be twenty + singular digit)
            // The first string will be twelve since 00 is twelve o' clock
            string[] time = new string[] { "twelve", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string conj;
            int min = m, ho = h, tens, digit;

            // For 00, 15, 30, and 45 minutes scenario
            if (min == 00)
            {
                return time[ho] + " o' clock";
            }
            if (min == 15)
            {
                return "quarter past " + time[ho];
            }
            else if (min == 30)
            {
                return "half past " + time[ho];
            }
            else if (min == 45)
            {
                // 45 minutes will use conjuction to -> we will return the next hour
                return "quarter to " + time[ho + 1];
            }

            // if min > 30 conjuction will become to and hour will become the next hour
            // min will become 60 - min (e.g 47 minutes will become 13 minutes to next hour)
            if (min > 30)
            {
                conj = " to ";
                min = 60 - min;
                ho++;
                // In case the hour goes to 13
                if (ho == 13)
                {
                    ho -= 12;
                }
            }
            else
            {
                conj = " past ";
            }

            // Set the tens and singular digit for minutes
            tens = min / 10;
            digit = min % 10;

            // If tens is 0 we will check whether the digit is 1 or not
            if (tens == 0)
            {
                // If digit == 1 -> it is singular (minute)
                if (digit == 1)
                {
                    return time[digit] + " minute" + conj + time[ho];
                }
                // Else it is plural (minutes)
                return time[digit] + " minutes" + conj + time[ho];
            }
            else if (tens == 1)
            {
                // We will use the whole min for the index
                return time[min] + " minutes" + conj + time[ho];
            }
            else
            {
                if (digit == 0)
                {
                    // Don't have any digits
                    return "twenty minutes" + conj + time[ho];
                }
                else
                {
                    return "twenty " + time[digit] + " minutes" + conj + time[ho];
                }
            }
        }
    }
}
