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

namespace LeetCode.Algorithms.CountNumberOfMaximumBitwiseORSubsets;

/// <summary>
///     https://leetcode.com/problems/count-number-of-maximum-bitwise-or-subsets/description/
/// </summary>
public interface ICountNumberOfMaximumBitwiseORSubsets
{
    /// <summary>
    ///     Counts the non-empty subsets of <paramref name="nums" /> whose bitwise OR equals the maximum possible bitwise OR
    ///     of any subset of the array.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <returns>The number of subsets with the maximum bitwise OR.</returns>
    int CountMaxOrSubsets(int[] nums);
}