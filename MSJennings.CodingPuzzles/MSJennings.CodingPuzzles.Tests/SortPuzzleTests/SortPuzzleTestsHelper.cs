using System;

namespace MSJennings.CodingPuzzles.Tests.SortPuzzleTests
{
    public static class SortPuzzleTestsHelper
    {
        #region Public Methods

        public static int[] GetRandomIntArray(int size)
        {
            var arr = new int[size];
            var rand = new Random();

            for (var i = 0; i < size; i++)
            {
                arr[i] = rand.Next(size); // duplicate values are ok
            }

            return arr;
        }

        #endregion Public Methods
    }
}
