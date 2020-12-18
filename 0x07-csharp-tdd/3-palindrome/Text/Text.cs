using System;

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
            if (s.Length == 0)
                return(true);

            string str = s;
            str = str.ToLower();
            str = str.Trim(' ', ',', '.', ':', ';');

            int i = 0;
            int j = str.Length - 1;

            for ( ; i < j ; i++, j--)
            {
                if (str[i] != str[j])
                    return(false);
            }
            return(true);
        }
    }
}
