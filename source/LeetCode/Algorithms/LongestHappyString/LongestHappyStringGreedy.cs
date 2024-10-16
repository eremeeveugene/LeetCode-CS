// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using System.Text;

namespace LeetCode.Algorithms.LongestHappyString;

/// <inheritdoc />
public class LongestHappyStringGreedy : ILongestHappyString
{
    /// <summary>
    ///     Time complexity - O(a + b + c)
    ///     Space complexity - O(a + b + c)
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public string LongestDiverseString(int a, int b, int c)
    {
        var stringBuilder = new StringBuilder();

        var counts = new List<(int Count, char Char)>();

        if (a > 0)
        {
            counts.Add((a, 'a'));
        }

        if (b > 0)
        {
            counts.Add((b, 'b'));
        }

        if (c > 0)
        {
            counts.Add((c, 'c'));
        }

        while (counts.Count > 0)
        {
            counts.Sort((x, y) => y.Count.CompareTo(x.Count));

            var isAdded = false;

            for (var i = 0; i < counts.Count; i++)
            {
                if (stringBuilder.Length >= 2 && stringBuilder[^1] == counts[i].Char &&
                    stringBuilder[^2] == counts[i].Char)
                {
                    continue;
                }

                stringBuilder.Append(counts[i].Char);
                counts[i] = (counts[i].Count - 1, counts[i].Char);

                isAdded = true;

                if (counts[i].Count == 0)
                {
                    counts.Remove(counts[i]);
                }

                break;
            }

            if (!isAdded)
            {
                break;
            }
        }

        return stringBuilder.ToString();
    }
}