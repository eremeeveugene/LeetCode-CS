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

namespace LeetCode.Algorithms.RangeSumQueryImmutable;

/// <inheritdoc />
public sealed class RangeSumQueryImmutablePrefixSum : IRangeSumQueryImmutable
{
    private readonly int[] _prefixSum;

    /// <summary>
    ///     Initializes a new instance of the <see cref="RangeSumQueryImmutablePrefixSum" /> class.
    /// </summary>
    /// <param name="nums">The array of integers to query range sums on.</param>
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public RangeSumQueryImmutablePrefixSum(int[] nums)
    {
        _prefixSum = new int[nums.Length + 1];

        for (var i = 0; i < nums.Length; i++)
        {
            _prefixSum[i + 1] = _prefixSum[i] + nums[i];
        }
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public int SumRange(int left, int right)
    {
        return _prefixSum[right + 1] - _prefixSum[left];
    }
}