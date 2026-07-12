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

namespace LeetCode.Algorithms.ContainsDuplicate3;

/// <summary>
///     https://leetcode.com/problems/contains-duplicate-iii/description/
/// </summary>
public interface IContainsDuplicate3
{
    /// <summary>
    ///     Determines whether there exist two distinct indices in <paramref name="nums" /> whose index difference is at
    ///     most <paramref name="indexDiff" /> and whose value difference is at most <paramref name="valueDiff" />.
    /// </summary>
    /// <param name="nums">The array of integers to check.</param>
    /// <param name="indexDiff">The maximum allowed difference between the indices.</param>
    /// <param name="valueDiff">The maximum allowed difference between the values.</param>
    /// <returns>
    ///     <see langword="true" /> if such a pair of indices exists; otherwise, <see langword="false" />.
    /// </returns>
    bool ContainsNearbyAlmostDuplicate(int[] nums, int indexDiff, int valueDiff);
}