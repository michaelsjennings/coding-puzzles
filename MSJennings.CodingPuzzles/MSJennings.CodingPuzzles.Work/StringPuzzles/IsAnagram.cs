using System.Collections.Generic;

namespace MSJennings.CodingPuzzles.Work.StringPuzzles
{
    public class IsAnagram
    {
        public bool GetResult(string s1, string s2)
        {
            if (s1 is null || s2 is null)
            {
                return false;
            }

            if (s1.Length != s2.Length)
            {
                return false;
            }

            IDictionary<char, int> GetCharacterCounts(string s)
            {
                var characterCounts = new Dictionary<char, int>();

                for (var i = 0; i < s.Length; i++)
                {
                    var c = s[i];

                    if (characterCounts.TryGetValue(c, out var count))
                    {
                        characterCounts[c] = count + 1;
                    }
                    else
                    {
                        characterCounts[c] = 1;
                    }
                }

                return characterCounts;
            }

            var dic1 = GetCharacterCounts(s1);
            var dic2 = GetCharacterCounts(s2);

            foreach (var item in dic1)
            {
                if (dic2.TryGetValue(item.Key, out var count))
                {
                    if (count != item.Value)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
