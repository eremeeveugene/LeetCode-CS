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

namespace LeetCode.Algorithms.ArrayPartition;

/// <summary>
///     https://leetcode.com/problems/array-partition/
/// </summary>
public interface IArrayPartition
{
    /// <summary>
    ///     Pairs up the elements of <paramref name="nums" /> to maximize the sum of the minimum of each pair.
    /// </summary>
    /// <param name="nums">The array of integers to pair up.</param>
    /// <returns>The maximum possible sum of the minimums of each pair.</returns>
    int ArrayPairSum(int[] nums);
}