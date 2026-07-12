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

namespace LeetCode.Algorithms.TwoSum2InputArrayIsSorted;

/// <summary>
///     https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/
/// </summary>
public interface ITwoSum2InputArrayIsSorted
{
    /// <summary>
    ///     Finds the 1-based indices of the two elements in the sorted array <paramref name="numbers" /> that add
    ///     up to <paramref name="target" />.
    /// </summary>
    /// <param name="numbers">The array of integers sorted in non-decreasing order to search.</param>
    /// <param name="target">The target sum to find among two elements.</param>
    /// <returns>An array containing the 1-based indices of the two numbers that add up to <paramref name="target" />.</returns>
    int[] TwoSum(int[] numbers, int target);
}