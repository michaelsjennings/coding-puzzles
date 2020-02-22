using System;
using System.Collections.Generic;

namespace MSJennings.CodingPuzzles.Work.ArrayPuzzles
{
    public class FindDuplicateInteger
    {
        #region Public Methods

        public int[] GetResult(int[] arr)
        {
            var alreadySeen = new HashSet<int>();
            var duplicates = new List<int>();

            for (var i = 0; i < arr.Length; i++)
            {
                var value = arr[i];
                if (alreadySeen.Contains(value))
                {
                    duplicates.Add(value);
                }
                else
                {
                    alreadySeen.Add(value);
                }
            }

            return duplicates.ToArray();
        }

        #endregion Public Methods
    }
}
