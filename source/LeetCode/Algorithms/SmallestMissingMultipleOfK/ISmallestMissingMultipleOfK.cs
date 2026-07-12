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

namespace LeetCode.Algorithms.SmallestMissingMultipleOfK;

/// <summary>
///     https://leetcode.com/problems/smallest-missing-multiple-of-k/description/
/// </summary>
public interface ISmallestMissingMultipleOfK
{
    /// <summary>
    ///     Finds the smallest positive multiple of <paramref name="k" /> that does not appear in
    ///     <paramref name="nums" />.
    /// </summary>
    /// <param name="nums">The array of integers to check against.</param>
    /// <param name="k">The value whose multiples are considered.</param>
    /// <returns>The smallest positive multiple of <paramref name="k" /> missing from <paramref name="nums" />.</returns>
    int MissingMultiple(int[] nums, int k);
}