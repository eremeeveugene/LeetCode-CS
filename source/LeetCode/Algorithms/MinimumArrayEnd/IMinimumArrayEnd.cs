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

namespace LeetCode.Algorithms.MinimumArrayEnd;

/// <summary>
///     https://leetcode.com/problems/minimum-array-end/description/
/// </summary>
public interface IMinimumArrayEnd
{
    /// <summary>
    ///     Finds the minimum possible last element of a strictly increasing array of <paramref name="n" /> positive
    ///     integers whose bitwise AND, when combined pairwise across the whole array, equals <paramref name="x" />.
    /// </summary>
    /// <param name="n">The number of positive integers in the array.</param>
    /// <param name="x">The value that the bitwise AND of all array elements must equal.</param>
    /// <returns>The minimum possible value of the last element of the array.</returns>
    long MinEnd(int n, int x);
}