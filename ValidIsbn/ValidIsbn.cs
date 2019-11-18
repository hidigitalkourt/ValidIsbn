using System;
using System.Collections.Generic;

namespace ValidIsbn
{
    public static class ValidateIsbn
    {
        public static bool IsValidIsbn(string isbn)
        {
            return
                IsLengthThirteen(ReducedIsbn(isbn)) &&
                HasValidCheckDigitForLengthThirteen(ReducedIsbn(isbn))
                ? true : false;
        }

        private static bool IsLengthThirteen(string isbn)
        {
            return isbn.Length != 13 ? false : true;
        }

        private static string ReducedIsbn(string isbn)
        {
            return isbn.Replace("-", "").Replace(" ", "");
        }

        public static int SumsAlternatingMulitpliersOfDigits(string isbn)
        {
            var index = 1;
            var sumDigits = 0;

            foreach (char ch in isbn)
            {
                if (index < 13)
                {
                    int num = int.Parse(Char.ToString(ch));
                    sumDigits += ((index % 2) == 0) ? (num * 3) : num;
                }
                index++;
            }
            return sumDigits;
        }

        public static bool HasValidCheckDigitForLengthThirteen(string isbn)
        {
            var checkDigit = (10 - (SumsAlternatingMulitpliersOfDigits(isbn) % 10)) % 10;
            var lastDigit = isbn[12];
            return checkDigit.ToString() == lastDigit.ToString() ? true : false;
        }
    }
}
