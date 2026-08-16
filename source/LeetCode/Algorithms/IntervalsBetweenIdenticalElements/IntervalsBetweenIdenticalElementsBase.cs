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
public abstract class IntervalsBetweenIdenticalElementsBase : IIntervalsBetweenIdenticalElements
{
    public abstract long[] GetDistances(int[] nums);

    /// <summary>
    ///     Records <paramref name="index" /> on the right side of <paramref name="state" />'s tracked number.
    /// </summary>
    /// <param name="state">The state to update.</param>
    /// <param name="index">The index being recorded.</param>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    protected static void AddToRight(ref State state, int index)
    {
        state.RightCount++;
        state.RightSum += index;
    }

    /// <summary>
    ///     Moves <paramref name="index" /> from the right side to the left side of <paramref name="state" />, and returns
    ///     the sum of distances from <paramref name="index" /> to every other index recorded in <paramref name="state" />.
    /// </summary>
    /// <param name="state">The state to update.</param>
    /// <param name="index">The index being moved.</param>
    /// <returns>The sum of absolute distances from <paramref name="index" /> to every other recorded equal index.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    protected static long MoveToLeftAndGetDistance(ref State state, int index)
    {
        state.RightCount--;
        state.RightSum -= index;

        var distance = (state.LeftCount * index) - state.LeftSum + state.RightSum - (state.RightCount * index);

        state.LeftCount++;
        state.LeftSum += index;

        return distance;
    }

    /// <summary>
    ///     Stores cumulative prefix and suffix state for a specific number:
    ///     left side count/sum and right side count/sum of indices.
    /// </summary>
    /// <param name="LeftCount">Number of equal elements to the left of the current index.</param>
    /// <param name="LeftSum">Sum of indices of equal elements to the left of the current index.</param>
    /// <param name="RightCount">Number of equal elements to the right of the current index.</param>
    /// <param name="RightSum">Sum of indices of equal elements to the right of the current index.</param>
    protected record struct State(long LeftCount, long LeftSum, long RightCount, long RightSum);
}