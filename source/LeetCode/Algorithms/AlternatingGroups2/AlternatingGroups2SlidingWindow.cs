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

namespace LeetCode.Algorithms.AlternatingGroups2;

/// <inheritdoc />
public sealed class AlternatingGroups2SlidingWindow : IAlternatingGroups2
{
    /// <summary>
    ///     Time complexity - O(n + k)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="colors"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int NumberOfAlternatingGroups(int[] colors, int k)
    {
        var count = 1;
        var result = 0;

        for (var i = 0; i < colors.Length - 1 + k - 1; i++)
        {
            if (colors[i % colors.Length] != colors[(i + 1) % colors.Length])
            {
                count++;
            }

            else
            {
                count = 1;
            }

            if (count >= k)
            {
                result++;
            }
        }

        return result;
    }
}