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
            return isbn.Replace("-","").Replace(" ","");
        }

        private static string HasValidCheckDigit(string isbn)
        {
            var index = 0;
            var multipledIntegers = 0;
            int numberIsbn = int.Parse(isbn);
            foreach ( int ch in isbn)
            {
                index ++;
                if ( index % 2 == 0)
                {

                }
            }
            return  multipledIntegers.ToString();
        }
    }
}
