﻿using System;
using System.Collections.Generic;

namespace ValidIsbn
{
    public static class ValidateIsbn
    {
        public static bool IsValidIsbn(string isbn)
        {
            var reducedIsbn = ReducedIsbn(isbn);
            var checkedLengthIsbn = IsLengthThirteen(reducedIsbn);

            return checkedLengthIsbn == null ? false : true;
        }

        private static string IsLengthThirteen(string isbn)
        {
            return isbn.Length != 13 ? null : isbn;
        }

        private static string ReducedIsbn(string isbn)
        {
            return isbn.Replace("-", "").Replace(" ", "");
        }

        public static int SumsAlternatingMulitpliersOfDigits(string isbn)
        {
            var reduced = ReducedIsbn(isbn);
            IsLengthThirteen(reduced);
            var index = 1;
            var sumDigits = 0;

            foreach (char ch in reduced)
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


    }
}
