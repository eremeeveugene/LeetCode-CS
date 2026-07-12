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

namespace LeetCode.Algorithms.CountSpecialTriplets;

/// <summary>
///     https://leetcode.com/problems/count-special-triplets/description/
/// </summary>
public interface ICountSpecialTriplets
{
    /// <summary>
    ///     Counts the special triplets (i, j, k) with i &lt; j &lt; k in <paramref name="nums" /> such that
    ///     <paramref name="nums" />[i] and <paramref name="nums" />[k] are both equal to twice
    ///     <paramref name="nums" />[j].
    /// </summary>
    /// <param name="nums">The array of integers to examine.</param>
    /// <returns>The number of special triplets, modulo 10^9 + 7.</returns>
    int SpecialTriplets(int[] nums);
}