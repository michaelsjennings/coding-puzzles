using System;

namespace MSJennings.CodingPuzzles.Work.StringPuzzles
{
    public class ArePalindromesOfEachOther
    {
        #region Public Methods

        public bool GetResult(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            // todo: can stop at half-way point
            for (var i = 0; i < s1.Length; i++)
            {
                var j = s2.Length - 1 - i;

                var c1 = s1[i];
                var c2 = s2[j];

                if (c1 != c2)
                {
                    return false;
                }
            }

            return true;
        }

        #endregion Public Methods
    }
}
