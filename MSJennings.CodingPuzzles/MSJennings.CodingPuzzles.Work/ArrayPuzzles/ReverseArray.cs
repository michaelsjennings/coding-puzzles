namespace MSJennings.CodingPuzzles.Work.ArrayPuzzles
{
    public class ReverseArray
    {
        #region Public Methods

        public void Go(int[] arr)
        {
            var i = 0;
            var j = arr.Length - 1;

            while (i < j)
            {
                var temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;

                i++;
                j--;
            }
        }

        #endregion Public Methods
    }
}
