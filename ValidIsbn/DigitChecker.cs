using System;
using System.Collections.Generic;

namespace ValidIsbn
{
    public static class DigitChecker
    {
        public static bool HasValidCheckDigit(string isbn)
        {
            return isbn.Length == 13 ? 
            GetCheckDigitForIsbnThirteen(isbn).ToString() == isbn[12].ToString() :
            GetCheckDigitForIsbnTen(isbn).ToString() == isbn[9].ToString();
        }     
        public static int GetSumOfMultipliedDigits(string isbn)
        {
            var index = 1;
            var sum = 0;

            foreach (char ch in isbn.Substring(0,isbn.Length -1))
            {
                int num = int.Parse(Char.ToString(ch));
                if( isbn.Length == 13)
                {
                    sum += ((index % 2) == 0) ? (num * 3) : num;
                }
                else
                {
                    sum += (index * num);
                }
                index++;
            }
            return sum;
        }   
        public static string GetCheckDigitForIsbnTen(string isbn)
        {
            return (GetSumOfMultipliedDigits(isbn) % 11) == 10 ? "X" :(GetSumOfMultipliedDigits(isbn) % 11).ToString();
        }
        public static string GetCheckDigitForIsbnThirteen(string isbn)
        {
            return (10 - (GetSumOfMultipliedDigits(isbn) % 10) % 10).ToString();
        }
    }
    
}