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

namespace LeetCode.Algorithms.LargestDivisibleSubset;

/// <summary>
///     https://leetcode.com/problems/largest-divisible-subset/description/
/// </summary>
public interface ILargestDivisibleSubset
{
    /// <summary>
    ///     Finds the largest subset of <paramref name="nums" /> in which every pair of elements satisfies that one divides
    ///     the other.
    /// </summary>
    /// <param name="nums">The array of distinct positive integers.</param>
    /// <returns>The largest divisible subset of <paramref name="nums" />.</returns>
    IList<int> LargestDivisibleSubset(int[] nums);
}