using System;

namespace MSJennings.CodingPuzzles.Work.IntegerPuzzles
{
    public class ReverseInteger
    {
        public int GetResult(int value)
        {
            var result = 0;

            while (value != 0)
            {
                var modResult = value % 10;

                result = result * 10 + modResult;
                value = value / 10;
            }

            return result;
        }
    }
}
