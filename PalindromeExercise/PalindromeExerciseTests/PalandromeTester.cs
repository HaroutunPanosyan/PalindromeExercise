using PalindromeExercise;
using System;
using System.Reflection.Emit;
using Xunit;

namespace PalindromeExerciseTests
{
    public class PalandromeTester
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Racecar", true)]
        [InlineData("racEcAR", true)]
        [InlineData("Radar", true)]
        [InlineData("Rotator", true)]
        [InlineData("Civic", true)]
        [InlineData("Deified", true)]
        [InlineData("Noon", true)]
        [InlineData("Kayak", true)]
        [InlineData("Madam", true)]
        [InlineData("Refer", true)]
        [InlineData("CiVvVic", true)]
        [InlineData("Nothing", false)]
        [InlineData("Ruebarb", false)]
        [InlineData("GoldLog", true)]
        [InlineData("Sweet", false)]
        [InlineData("Simple", false)]
        [InlineData("Serious", false)]
        [InlineData("KaYAk", true)]
        [InlineData("IsThisAWord", false)]
        [InlineData("WeShouldAllPlayGames", false)]
        [InlineData("Green", false)]
        [InlineData("FireIsHot", false)]
        public void PalandromeTest(string word, bool expected)
        {
            //Arrange
            Palandrome palTest = new Palandrome();

            //Act
            bool actual = palTest.Check(word);


            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
