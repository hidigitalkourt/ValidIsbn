using System;
using System.Collections.Generic;

namespace ValidIsbn
{
    public static class ValidateIsbn
    {
        public static bool IsValidIsbn(string isbn)
        {   
            var isbnCharList = new string []{};
            string processedIsbn;
            if( isbn == null || isbn == "")
            {
                return false;
            }
            if( isbn.Contains("-"))
            {
                isbnCharList = isbn.Split('-');
                processedIsbn = String.Join("",isbnCharList);
                if (processedIsbn.Length != 13) 
                {
                    return false;
                }
                return true;
            } 
            if( isbn.Length != 13)
            {
                return false;
            }
            return true;
        }
    }
}
