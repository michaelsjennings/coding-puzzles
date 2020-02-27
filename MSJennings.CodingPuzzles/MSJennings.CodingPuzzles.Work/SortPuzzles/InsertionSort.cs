namespace MSJennings.CodingPuzzles.Work.SortPuzzles
{
    public class InsertionSort
    {
        #region Public Methods

        public void Sort(int[] arr)
        {
            for (var i = 0; i < arr.Length - 1; i++)
            {
                for (var j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }
        }

        #endregion Public Methods
    }
}
