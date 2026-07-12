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

namespace LeetCode.Algorithms.TheNumberOfBeautifulSubsets;

/// <summary>
///     https://leetcode.com/problems/the-number-of-beautiful-subsets/
/// </summary>
public interface ITheNumberOfBeautifulSubsets
{
    /// <summary>
    ///     Counts the number of non-empty subsets of <paramref name="nums" /> that contain no two elements whose
    ///     absolute difference equals <paramref name="k" />.
    /// </summary>
    /// <param name="nums">The array of positive integers to choose subsets from.</param>
    /// <param name="k">The forbidden absolute difference between any two elements of a valid subset.</param>
    /// <returns>The number of beautiful subsets of <paramref name="nums" />.</returns>
    int BeautifulSubsets(int[] nums, int k);
}