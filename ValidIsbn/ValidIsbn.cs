using System;
using System.Collections.Generic;

namespace ValidIsbn
{
    public static class ValidateIsbn
    {
        public static bool IsValidIsbn(string isbn)
        {   
            if( isbn.Contains("-"))
            {
                var isbnCharList = isbn.Split('-');
                string processedIsbn = String.Join("",isbnCharList);
                return IsLengthThirteen(processedIsbn);
            } 
            if( isbn.Contains(" "))
            {
                var isbnCharList = isbn.Split(' ');
                string processedIsbn = String.Join("",isbnCharList);
                return IsLengthThirteen(processedIsbn);
            }
            return IsLengthThirteen(isbn);
        }

        private static bool IsLengthThirteen(string isbn)
        {
            return isbn.Length != 13 ? false : true;
        }
    }
}
