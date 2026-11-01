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

namespace LeetCode.Algorithms.MinimumMovesToEqualArrayElements;

/// <inheritdoc />
public sealed class MinimumMovesToEqualArrayElementsOnePass : IMinimumMovesToEqualArrayElements
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinMoves(int[] nums)
    {
        var n = nums.Length;

        var min = int.MaxValue;

        var sum = 0;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            min = Math.Min(min, num);

            sum += num;
        }

        return sum - (min * n);
    }
}