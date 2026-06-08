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
public sealed class IntervalsBetweenIdenticalElementsSpan : IntervalsBetweenIdenticalElementsBase
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

        Span<State> states = stackalloc State[MaxValue + 1];

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            ref var state = ref states[num];

            state.RightCount++;
            state.RightSum += i;
        }

        var result = new long[n];

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            ref var state = ref states[num];

            state.RightCount--;
            state.RightSum -= i;

            result[i] = (state.LeftCount * i) - state.LeftSum + state.RightSum - (state.RightCount * i);

            state.LeftCount++;
            state.LeftSum += i;
        }

        return result;
    }
}