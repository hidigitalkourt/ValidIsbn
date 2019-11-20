﻿using System;
using System.Collections.Generic;

namespace ThirteenDigitIsbnValidator
{
    public static class IsbnValidator
    {
        public static bool IsThirteenDigitIsbnValidator(string isbn)
        {
            return IsLengthThirteen(ReducedIsbn(isbn)) && DigitChecker.HasValidCheckDigitForLengthThirteen(ReducedIsbn(isbn));
        }

        private static bool IsLengthThirteen(string isbn)
        {
            return isbn.Length == 13;
        }

        private static string ReducedIsbn(string isbn)
        {
            return isbn.Replace("-", "").Replace(" ", "");
        }    
    }
}
