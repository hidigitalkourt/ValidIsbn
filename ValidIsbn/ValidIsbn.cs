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

            return checkedLengthIsbn == null ? false : HasValidCheckDigit(checkedLengthIsbn);
        }

        private static string IsLengthThirteen(string isbn)
        {
            return isbn.Length != 13 ? null : isbn;
        }

        private static string ReducedIsbn(string isbn)
        {
            return isbn.Replace("-","").Replace(" ","");
        }

        private static bool HasValidCheckDigit(string isbn)
        {
            var index = 0;
            var aggregatedIntegers = 0;
            while (index < 13)
            {
                index++;
                foreach (char ch in isbn)
                {
                    int num = int.Parse(Char.ToString(ch));
                    aggregatedIntegers += index % 2 == 0 ? num * 3 : num;
                }
            }
            var checkDigit = (10 - (aggregatedIntegers % 10)) % 10;
            var lastDigit = isbn[12];
            return checkDigit.ToString() == lastDigit.ToString() ? true : false;
        }
    }
}
