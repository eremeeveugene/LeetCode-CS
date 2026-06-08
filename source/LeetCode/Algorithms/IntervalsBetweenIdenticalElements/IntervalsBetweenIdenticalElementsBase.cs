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
    /// <inheritdoc />
    public abstract long[] GetDistances(int[] nums);

    /// <summary>
    ///     Stores cumulative prefix and suffix state for a specific number:
    ///     left side count/sum and right side count/sum of indices.
    /// </summary>
    protected struct State
    {
        /// <summary>
        ///     Number of equal elements to the left of the current index.
        /// </summary>
        public long LeftCount;

        /// <summary>
        ///     Sum of indices of equal elements to the left of the current index.
        /// </summary>
        public long LeftSum;

        /// <summary>
        ///     Number of equal elements to the right of the current index.
        /// </summary>
        public long RightCount;

        /// <summary>
        ///     Sum of indices of equal elements to the right of the current index.
        /// </summary>
        public long RightSum;
    }
}