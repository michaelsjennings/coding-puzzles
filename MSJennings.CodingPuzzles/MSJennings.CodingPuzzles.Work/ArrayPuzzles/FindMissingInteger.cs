﻿using System;

namespace MSJennings.CodingPuzzles.Work.ArrayPuzzles
{
    public class FindMissingInteger
    {
        #region Public Methods

        public Result GetResult(int[] arr)
        {
            var sumOfAll = 0;
            var sumOfPresent = 0;

            var missingIndex = -1;

            for (var i = 0; i < arr.Length; i++)
            {
                sumOfAll += (i + 1);

                if (arr[i] < 1)
                {
                    missingIndex = i;
                }
                else
                {
                    sumOfPresent += arr[i];
                }
            }

            return new Result
            {
                MissingIndex = missingIndex,
                MissingValue = (sumOfAll - sumOfPresent)
            };
        }

        #endregion Public Methods

        #region Public Classes

        public class Result
        {
            #region Public Fields

            public int MissingIndex;
            public int MissingValue;

            #endregion Public Fields
        }

        #endregion Public Classes
    }
}
