using System;

namespace ValidIsbn
{
    public static class ValidateIsbn
    {
        public static bool IsValidIsbn(string isbn)
        {   
            if( isbn == null || isbn == "")
            {
                return false;
            }
            if( isbn.Length != 10)
            {
                return false;
            }
            return true;
        }
    }
}
