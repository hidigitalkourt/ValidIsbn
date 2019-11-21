using System;
using System.Collections.Generic;

namespace ValidIsbn
{
    public static class IsbnValidator
    {
        public static bool IsValidIsbn(string isbn)
        {
            return IsLengthValid(ReducedIsbn(isbn)) && DigitChecker.HasValidCheckDigit(ReducedIsbn(isbn));
        }

        private static bool IsLengthValid(string isbn)
        {
            return isbn.Length == 13 || isbn.Length == 10;
        }

        private static string ReducedIsbn(string isbn)
        {
            return isbn.Replace("-", "").Replace(" ", "");
        }    
    }
}
