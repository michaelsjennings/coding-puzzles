using System.Collections.Generic;

namespace MSJennings.CodingPuzzles.Work.ArrayPuzzles
{
    public class FindPairsYieldingSum
    {
        #region Public Methods

        public IList<(int, int)> GetResult(int[] arr, int sum)
        {
            var result = new List<(int, int)>();

            // brute force - O(n^2)
            /*
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == sum)
                    {
                        result.Add((arr[i], arr[j]));
                    }
                }
            }
            */

            return result;
        }

        #endregion Public Methods
    }
}
