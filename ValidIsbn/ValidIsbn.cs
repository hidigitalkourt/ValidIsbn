using System;
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

        public static int ModulusTenOfResult(string isbn)
        {
            return SumsAlternatingMulitpliersOfDigits(isbn) % 10;
        }

        public static int ModulusTenOfSubtractedResult(string isbn)
        {
            return 0;
        }

    }
}
