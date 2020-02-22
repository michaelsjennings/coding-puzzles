using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSJennings.CodingPuzzles.Work.ArrayPuzzles;
using System;
using System.Collections.Generic;

namespace MSJennings.CodingPuzzles.Tests.ArrayPuzzleTests
{
    [TestClass]
    public class FindMissingIntegerTests
    {
        #region Public Methods

        [TestMethod]
        public void GetResult_WithArraySize100_ReturnsCorrectResult()
        {
            // Arrange
            var arr = BuildArray(100);
            var (removedIndex, removedValue) = RemoveOne(arr);

            var sut = new FindMissingInteger();

            // Act
            var result = sut.GetResult(arr);

            // Assert
            Assert.AreEqual(removedIndex, result.MissingIndex, "Removed index is not correct");
            Assert.AreEqual(removedValue, result.MissingValue, "Removed value is not correct");
        }

        #endregion Public Methods

        #region Private Methods

        private int[] BuildArray(int size)
        {
            var arr = new int[size];

            var alreadyUsed = new List<int>();
            var random = new Random();

            for (var i = 0; i < size; i++)
            {
                var n = random.Next(1, size + 1);

                while (alreadyUsed.Contains(n))
                {
                    n = random.Next(1, size + 1);
                }

                arr[i] = n;
                alreadyUsed.Add(n);
            }

            return arr;
        }

        private (int Index, int Value) RemoveOne(int[] arr)
        {
            var random = new Random();

            var index = random.Next(0, arr.Length);
            var value = arr[index];

            arr[index] = 0;
            return (index, value);
        }

        #endregion Private Methods
    }
}
