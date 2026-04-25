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

using System.Runtime.InteropServices;

namespace LeetCode.Algorithms.SumOfDistances;

/// <inheritdoc />
public sealed class SumOfDistancesGroupedPrefixSuffix : ISumOfDistances
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(k), where k is the number of distinct numbers
    /// </remarks>
    public long[] Distance(int[] nums)
    {
        var numsLength = nums.Length;

        var numToStateDictionary = new Dictionary<int, State>(numsLength);

        for (var index = 0; index < numsLength; index++)
        {
            var num = nums[index];

            ref var state = ref CollectionsMarshal.GetValueRefOrAddDefault(numToStateDictionary, num, out _);

            state.RightCount++;
            state.RightSum += index;
        }

        var result = new long[numsLength];

        for (var index = 0; index < numsLength; index++)
        {
            var num = nums[index];

            ref var state = ref CollectionsMarshal.GetValueRefOrAddDefault(numToStateDictionary, num, out _);

            state.RightCount--;
            state.RightSum -= index;

            result[index] = (state.LeftCount * index) - state.LeftSum + state.RightSum - (state.RightCount * index);

            state.LeftCount++;
            state.LeftSum += index;
        }

        return result;
    }

    /// <summary>
    ///     Stores cumulative prefix and suffix state for a specific number:
    ///     left side count/sum and right side count/sum of indices.
    /// </summary>
    private struct State
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