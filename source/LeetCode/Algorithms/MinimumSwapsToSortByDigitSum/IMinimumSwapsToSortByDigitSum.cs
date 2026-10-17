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

namespace LeetCode.Algorithms.MinimumSwapsToSortByDigitSum;

/// <summary>
///     https://leetcode.com/problems/minimum-swaps-to-sort-by-digit-sum/description/
/// </summary>
public interface IMinimumSwapsToSortByDigitSum
{
    /// <summary>
    ///     Computes the minimum number of swaps required to sort <paramref name="nums" /> in increasing order of digit sum,
    ///     breaking ties by the smaller value.
    /// </summary>
    /// <param name="nums">The array of distinct positive integers to sort.</param>
    /// <returns>The minimum number of swaps needed to reach the digit-sum sorted order.</returns>
    int MinSwaps(int[] nums);
}