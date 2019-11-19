using System;
using System.Collections.Generic;

namespace ValidIsbn
{
    public static class DigitChecker
    {
        public static bool HasValidCheckDigitForLengthThirteen(string isbn)
        {
            var checkDigit = (10 - (GetSumOfDigitsWithAlternatingMultiplier(isbn) % 10)) % 10;
            var lastDigit = isbn[12];
            return checkDigit.ToString() == lastDigit.ToString();
        }     

        public static int GetSumOfDigitsWithAlternatingMultiplier(string isbn)
        {
            var index = 1;
            var sum = 0;

            foreach (char ch in isbn)
            {
                if (index < 13)
                {
                    int num = int.Parse(Char.ToString(ch));
                    sum += ((index % 2) == 0) ? (num * 3) : num;
                }
                index++;
            }
            return sum;
        }   
    }
    
}