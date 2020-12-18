using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// This is our class Matrix.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// This is our class Matrix.
        /// </summary>
        public static bool IsPalindrome(string s)
        {
            string newString = String.Join("", s.ToLower().Split(' ', ',', '.', ':', ';', '\''));
            int strLen = newString.Length - 1;

            foreach (char letter in newString)
            {
                if ( letter != newString[strLen])
                    return false;
                strLen--;
            }
            return true;
        }
    }
}
