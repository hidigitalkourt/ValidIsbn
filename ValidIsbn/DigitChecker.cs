using System;
using System.Collections.Generic;

namespace ValidIsbn
{
    public static class DigitChecker
    {
        public static bool HasValidCheckDigit(string isbn)
        {
            string checkDigit;
            char lastDigit;
            if (isbn.Length == 13)
            {
                checkDigit = (10 - (GetSumOfMultipliedDigits(isbn) % 10) % 10).ToString();
                lastDigit = isbn[12];
            }
            else
            {
                checkDigit = (GetSumOfMultipliedDigits(isbn) % 11).ToString();
                lastDigit = isbn[9];
            }
            return checkDigit == lastDigit.ToString();
        }     

        public static int GetSumOfMultipliedDigits(string isbn)
        {
            var index = 1;
            var sum = 0;

            foreach (char ch in isbn)
            {
                int num = int.Parse(Char.ToString(ch));
                if (index < isbn.Length)
                {
                    if( isbn.Length == 13)
                    {
                        sum += ((index % 2) == 0) ? (num * 3) : num;
                    }
                    else
                    {
                        sum += (index * num);
                    }
                }
                index++;
            }
            return sum;
        }   
    }
    
}