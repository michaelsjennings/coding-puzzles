﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSJennings.CodingPuzzles.Work.StringPuzzles;

namespace MSJennings.CodingPuzzles.Tests.StringPuzzleTests
{
    [TestClass]
    public class AreAnagramsOfEachOtherTests
    {
        #region Public Methods

        [TestMethod]
        public void AreAnagramsOfEachother_WithNoAnagrams_ShouldReturnFalse()
        {
            // Arrange
            var sut = new AreAnagramsOfEachOther();

            var s1 = "abcd";
            var s2 = "dcca";

            // Act
            var result = sut.GetResult(s1, s2);

            // Assert
            Assert.IsFalse(result, "Result is incorrect");
        }

        [TestMethod]
        public void AreAnagramsOfEachother_WithYesAnagrams_ShouldReturnTrue()
        {
            // Arrange
            var sut = new AreAnagramsOfEachOther();

            var s1 = "abcd";
            var s2 = "dcba";

            // Act
            var result = sut.GetResult(s1, s2);

            // Assert
            Assert.IsTrue(result, "Result is incorrect");
        }

        #endregion Public Methods
    }
}
