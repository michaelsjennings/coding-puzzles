namespace MSJennings.CodingPuzzles.Work.SortPuzzles
{
    public class SelectionSort
    {
        #region Public Methods

        public void Sort(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                var minIndex = i;

                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (i != minIndex)
                {
                    var temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }

        #endregion Public Methods
    }
}
