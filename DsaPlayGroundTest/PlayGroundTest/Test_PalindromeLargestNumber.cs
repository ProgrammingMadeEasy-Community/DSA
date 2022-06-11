﻿using DsaPlayGround.PlayGround;
using Xunit;

namespace DsaPlayGroundTest.PlayGroundTest
{
    public class Test_PalindromeLargestNumber
    {
        [Fact]
        public void NullOrEmptyInput()
        {
            // Arrange
            var input = "";
            var expectedOutput = 0;

            // Act
            var actualOutput = PalindromeLargestNumber.LargestPalindrome(input);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void LengthOneInput()
        {
            // Arrange
            var input = "7";
            var expectedOutput = 7;

            // Act
            var actualOutput = PalindromeLargestNumber.LargestPalindrome(input);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void ValidInput()
        {
            // Arrange
            var input = "2345625";
            var expectedOutput = 52625;

            // Act
            var actualOutput = PalindromeLargestNumber.LargestPalindrome(input);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void LeadingZeroOutput()
        {
            // Arrange
            var input = "01009";
            var expectedOutput = 9;

            // Act
            var actualOutput = PalindromeLargestNumber.LargestPalindrome(input);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

    }
}
