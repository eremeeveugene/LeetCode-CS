using System.Text;

namespace LeetCode.Algorithms.IncreasingDecreasingString;

/// <inheritdoc />
public class IncreasingDecreasingStringCountingSort : IIncreasingDecreasingString
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string SortString(string s)
    {
        var count = new int[26];

        foreach (var c in s)
        {
            count[c - 'a']++;
        }

        var stringBuilder = new StringBuilder();

        while (stringBuilder.Length < s.Length)
        {
            for (var i = 0; i < 26; i++)
            {
                if (count[i] <= 0)
                {
                    continue;
                }

                stringBuilder.Append((char)(i + 'a'));

                count[i]--;
            }

            for (var i = 25; i >= 0; i--)
            {
                if (count[i] <= 0)
                {
                    continue;
                }

                stringBuilder.Append((char)(i + 'a'));

                count[i]--;
            }
        }

        return stringBuilder.ToString();
    }
}