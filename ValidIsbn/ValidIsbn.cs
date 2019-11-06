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
            return true;
        }
    }
}
