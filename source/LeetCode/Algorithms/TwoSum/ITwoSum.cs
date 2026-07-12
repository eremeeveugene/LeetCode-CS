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

namespace LeetCode.Algorithms.TwoSum;

/// <summary>
///     https://leetcode.com/problems/two-sum/description/
/// </summary>
public interface ITwoSum
{
    /// <summary>
    ///     Finds the indices of the two elements in <paramref name="nums" /> that add up to
    ///     <paramref name="target" />.
    /// </summary>
    /// <param name="nums">The array of integers to search.</param>
    /// <param name="target">The target sum to find among two elements.</param>
    /// <returns>An array containing the indices of the two numbers that add up to <paramref name="target" />.</returns>
    int[] TwoSum(int[] nums, int target);
}