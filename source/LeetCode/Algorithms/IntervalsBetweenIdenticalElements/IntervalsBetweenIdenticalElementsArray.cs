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

namespace LeetCode.Algorithms.IntervalsBetweenIdenticalElements;

/// <inheritdoc />
public sealed class IntervalsBetweenIdenticalElementsArray : IntervalsBetweenIdenticalElementsBase
{
    private const int MaxValue = 100_000;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public override long[] GetDistances(int[] nums)
    {
        var n = nums.Length;

        var states = new State[MaxValue + 1];

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            AddToRight(ref states[num], i);
        }

        var result = new long[n];

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            result[i] = MoveToLeftAndGetDistance(ref states[num], i);
        }

        return result;
    }
}