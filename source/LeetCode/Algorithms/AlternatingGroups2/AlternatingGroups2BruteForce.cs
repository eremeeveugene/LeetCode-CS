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
public sealed class AlternatingGroups2BruteForce : IAlternatingGroups2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * k)
    ///     Space complexity - O(1)
    /// </remarks>
    public int NumberOfAlternatingGroups(int[] colors, int k)
    {
        var numberOfAlternatingGroups = 0;

        for (var i = 0; i < colors.Length; i++)
        {
            var isAlternating = true;

            for (var j = 0; j < k - 1; j++)
            {
                var curr = colors[(i + j) % colors.Length];
                var next = colors[(i + j + 1) % colors.Length];

                if (curr != next)
                {
                    continue;
                }

                isAlternating = false;

                break;
            }

            if (isAlternating)
            {
                numberOfAlternatingGroups++;
            }
        }

        return numberOfAlternatingGroups;
    }
}