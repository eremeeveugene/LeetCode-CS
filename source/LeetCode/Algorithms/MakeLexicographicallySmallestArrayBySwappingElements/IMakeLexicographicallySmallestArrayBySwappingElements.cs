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

namespace LeetCode.Algorithms.MakeLexicographicallySmallestArrayBySwappingElements;

/// <summary>
///     https://leetcode.com/problems/make-lexicographically-smallest-array-by-swapping-elements/description/
/// </summary>
public interface IMakeLexicographicallySmallestArrayBySwappingElements
{
    /// <summary>
    ///     Returns the lexicographically smallest array obtainable by swapping values whose absolute difference does not exceed
    ///     <paramref name="limit" />.
    /// </summary>
    /// <param name="nums">The array of positive integers.</param>
    /// <param name="limit">The maximum difference allowed between two values being swapped.</param>
    /// <returns>The lexicographically smallest array obtainable through any number of valid swaps.</returns>
    int[] LexicographicallySmallestArray(int[] nums, int limit);
}