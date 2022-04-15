using System;
using Xunit;

namespace PalindromeExercise.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("hello", false)]
        [InlineData("kayak", true)]
        [InlineData("Tylor", false)]
        [InlineData("never odd or even", true)]
        [InlineData("was it a cat i saw", true)]
        public void PalindromeTester(string word, bool expected)
        {
            var tester = new WordSmith();

            var acutal = tester.IsAPalindrome(word);
            
            Assert.Equal(expected, acutal);
        }
    }
}
