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

namespace LeetCode.Algorithms.FindIfArrayCanBeSorted;

/// <summary>
///     https://leetcode.com/problems/find-if-array-can-be-sorted/description/
/// </summary>
public interface IFindIfArrayCanBeSorted
{
    /// <summary>
    ///     Determines whether <paramref name="nums" /> can be sorted in non-decreasing order using any number of swaps
    ///     of adjacent elements that have the same number of set bits.
    /// </summary>
    /// <param name="nums">The array of non-negative integers to check.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="nums" /> can be sorted under the given constraint; otherwise,
    ///     <see langword="false" />.
    /// </returns>
    bool CanSortArray(int[] nums);
}