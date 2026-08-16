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

namespace LeetCode.Algorithms.IntervalsBetweenIdenticalElements;

/// <inheritdoc />
public sealed class IntervalsBetweenIdenticalElementsDictionary : IntervalsBetweenIdenticalElementsBase
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public override long[] GetDistances(int[] nums)
    {
        var n = nums.Length;

        var numToStateDictionary = new Dictionary<int, State>(n);

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            ref var state = ref CollectionsMarshal.GetValueRefOrAddDefault(numToStateDictionary, num, out _);

            AddToRight(ref state, i);
        }

        var result = new long[n];

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            ref var state = ref CollectionsMarshal.GetValueRefOrAddDefault(numToStateDictionary, num, out _);

            result[i] = MoveToLeftAndGetDistance(ref state, i);
        }

        return result;
    }
}