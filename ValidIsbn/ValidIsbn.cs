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

        
    }
}
