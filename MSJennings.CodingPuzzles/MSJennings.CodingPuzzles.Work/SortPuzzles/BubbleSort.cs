using System;

namespace MSJennings.CodingPuzzles.Work.SortPuzzles
{
    public class BubbleSort
    {
        #region Public Methods

        public void Sort(int[] arr)
        {
            for (var i = 0; i < arr.Length - 1; i++)
            {
                for (var j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        #endregion Public Methods
    }
}
