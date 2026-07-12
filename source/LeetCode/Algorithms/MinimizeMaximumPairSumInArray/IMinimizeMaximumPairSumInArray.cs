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

namespace LeetCode.Algorithms.MinimizeMaximumPairSumInArray;

/// <summary>
///     https://leetcode.com/problems/minimize-maximum-pair-sum-in-array/description/
/// </summary>
public interface IMinimizeMaximumPairSumInArray
{
    /// <summary>
    ///     Pairs up the elements of <paramref name="nums" /> to minimize the maximum sum among all the pairs.
    /// </summary>
    /// <param name="nums">The array of integers to pair up.</param>
    /// <returns>The minimized maximum pair sum.</returns>
    int MinPairSum(int[] nums);
}