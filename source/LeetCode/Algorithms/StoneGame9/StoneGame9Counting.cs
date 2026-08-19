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

namespace LeetCode.Algorithms.StoneGame9;

/// <inheritdoc />
public sealed class StoneGame9Counting : IStoneGame9
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool StoneGameIX(int[] stones)
    {
        var n = stones.Length;

        var remainderCounts = new int[3];

        for (var i = 0; i < n; i++)
        {
            var stone = stones[i];

            remainderCounts[stone % 3]++;
        }

        if (remainderCounts[0] % 2 == 0)
        {
            return remainderCounts[1] > 0 && remainderCounts[2] > 0;
        }

        return Math.Abs(remainderCounts[1] - remainderCounts[2]) > 2;
    }
}