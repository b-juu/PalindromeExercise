using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)] 
        public void IsAPalindromeTest(string input, bool expected)
        {          
            WordSmith wordSmith = new WordSmith();
            bool result = wordSmith.IsAPalindrome(input);
            Assert.Equal(expected, result);
        }
    }
}
