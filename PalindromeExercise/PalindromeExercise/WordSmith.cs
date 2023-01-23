using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {

        }

        public bool IsAPalindrome(string palindrome)
        {
            //throw new NotImplementedException();
            var wordReverse = "";

            for(var i = palindrome.Length - 1; i >= 0; i--)
            {
                wordReverse += palindrome[i];
            }

            if (palindrome == wordReverse.ToLower())
            {
                return true;
            }
            return false;

        }
    }
}
