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

namespace LeetCode.Algorithms.MonotonicArray;

/// <summary>
///     https://leetcode.com/problems/monotonic-array/
/// </summary>
public interface IMonotonicArray
{
    /// <summary>
    ///     Determines whether <paramref name="nums" /> is monotonic, meaning it is either entirely non-increasing or
    ///     entirely non-decreasing.
    /// </summary>
    /// <param name="nums">The array of integers to check for monotonicity.</param>
    /// <returns><see langword="true" /> if <paramref name="nums" /> is monotonic; otherwise, <see langword="false" />.</returns>
    bool IsMonotonic(int[] nums);
}