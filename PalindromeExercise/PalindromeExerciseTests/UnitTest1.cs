using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Racecar", true)]
        [InlineData("rAcEcAr", true)]
        [InlineData("Hello World", false)]
        [InlineData("Tacocat", true)]
        [InlineData("t a c o c a t", true)]
        public void TestingForAPalindrome(string word, bool expected)
        {
            //Arrange


            //Act
            var actual = Palindrome.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
