using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class Palindrome
    {
        public static bool IsAPalindrome(string word)
        {
            string palindrome = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                palindrome += word.ToLower()[i];
            }

            if (palindrome == word.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
