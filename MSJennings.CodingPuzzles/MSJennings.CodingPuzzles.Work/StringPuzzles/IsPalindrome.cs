using System;

namespace MSJennings.CodingPuzzles.Work.StringPuzzles
{
    public class IsPalindrome
    {
        #region Public Methods

        public bool GetResult(string s)
        {
            // todo: can stop at half-way point
            for (var i = 0; i < s.Length; i++)
            {
                var j = s.Length - 1 - i;

                var c1 = s[i];
                var c2 = s[j];

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
