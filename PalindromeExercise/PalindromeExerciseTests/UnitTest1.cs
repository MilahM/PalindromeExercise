using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("madam", true)]
        [InlineData("civic", true)]
        [InlineData("level", true)]
        [InlineData("radar", true)]
        [InlineData("car", false)]
        [InlineData("lever", false)]
        [InlineData("saloon", false)]

        public void IsAPalindromeTest(string palindrome, bool expected)
        {
            WordSmith word = new WordSmith();

            bool actual = word.IsAPalindrome(palindrome);

            Assert.Equal(expected, actual);
            
        }
    }
}
