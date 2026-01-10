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

namespace LeetCode.Algorithms.RangeSumQueryMutable;

/// <inheritdoc />
public sealed class RangeSumQueryMutablePrefixSum : IRangeSumQueryMutable
{
    private readonly int[] _nums;
    private readonly int[] _prefixSum;

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    public RangeSumQueryMutablePrefixSum(int[] nums)
    {
        _nums = nums;

        _prefixSum = new int[nums.Length + 1];

        for (var i = 0; i < nums.Length; i++)
        {
            _prefixSum[i + 1] = _prefixSum[i] + nums[i];
        }
    }

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="index"></param>
    /// <param name="val"></param>
    public void Update(int index, int val)
    {
        _nums[index] = val;

        for (var i = index; i < _nums.Length; i++)
        {
            _prefixSum[i + 1] = _prefixSum[i] + _nums[i];
        }
    }

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public int SumRange(int left, int right)
    {
        return _prefixSum[right + 1] - _prefixSum[left];
    }
}