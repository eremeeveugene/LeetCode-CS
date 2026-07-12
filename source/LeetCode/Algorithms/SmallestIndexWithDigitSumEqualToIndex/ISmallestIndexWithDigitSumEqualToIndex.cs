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

namespace LeetCode.Algorithms.SmallestIndexWithDigitSumEqualToIndex;

/// <summary>
///     https://leetcode.com/problems/smallest-index-with-digit-sum-equal-to-index/description/
/// </summary>
public interface ISmallestIndexWithDigitSumEqualToIndex
{
    /// <summary>
    ///     Finds the smallest index in <paramref name="nums" /> whose digit sum of the value at that index
    ///     equals the index itself.
    /// </summary>
    /// <param name="nums">The array of non-negative integers to search.</param>
    /// <returns>The smallest qualifying index, or -1 if none exists.</returns>
    int SmallestIndex(int[] nums);
}