// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.FindTheNumberOfDistinctColorsAmongTheBalls;

/// <inheritdoc />
public sealed class FindTheNumberOfDistinctColorsAmongTheBallsDictionary : IFindTheNumberOfDistinctColorsAmongTheBalls
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] QueryResults(int limit, int[][] queries)
    {
        var result = new int[queries.Length];
        var colorMap = new Dictionary<int, int>();
        var ballMap = new Dictionary<int, int>();

        for (var i = 0; i < queries.Length; i++)
        {
            var ball = queries[i][0];
            var color = queries[i][1];

            if (ballMap.TryGetValue(ball, out var prevColor))
            {
                colorMap[prevColor]--;

                if (colorMap[prevColor] == 0)
                {
                    colorMap.Remove(prevColor);
                }
            }

            ballMap[ball] = color;

            if (!colorMap.TryAdd(color, 1))
            {
                colorMap[color]++;
            }

            result[i] = colorMap.Count;
        }

        return result;
    }
}