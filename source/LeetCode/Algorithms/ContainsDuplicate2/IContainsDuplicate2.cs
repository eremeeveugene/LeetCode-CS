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

namespace LeetCode.Algorithms.ContainsDuplicate2;

/// <summary>
///     https://leetcode.com/problems/contains-duplicate-ii/
/// </summary>
public interface IContainsDuplicate2
{
    /// <summary>
    ///     Determines whether there are two distinct indices in <paramref name="nums" /> with equal values whose index
    ///     difference is at most <paramref name="k" />.
    /// </summary>
    /// <param name="nums">The array of integers to check.</param>
    /// <param name="k">The maximum allowed difference between the indices of the duplicate values.</param>
    /// <returns>
    ///     <see langword="true" /> if such a pair of indices exists; otherwise, <see langword="false" />.
    /// </returns>
    bool ContainsNearbyDuplicate(int[] nums, int k);
}