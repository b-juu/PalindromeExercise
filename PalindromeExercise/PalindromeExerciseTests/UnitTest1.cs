using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("signa te signa temere me tangis et angis", true)]
        [InlineData("roma tibi subito motibus ibit amor", true)]
        [InlineData("sator arepo tenet opera rotas", true)]
        [InlineData("in girum imus nocte et consumimur igni", true)]
        public void IsAPalindromeTest(string input, bool expected)
        {          
            WordSmith wordSmith = new WordSmith();
            bool result = wordSmith.IsAPalindrome(input);
            Assert.Equal(expected, result);
        }
    }
}
