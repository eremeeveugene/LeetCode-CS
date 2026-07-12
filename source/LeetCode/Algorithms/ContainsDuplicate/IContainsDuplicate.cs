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

namespace LeetCode.Algorithms.ContainsDuplicate;

/// <summary>
///     https://leetcode.com/problems/contains-duplicate/
/// </summary>
public interface IContainsDuplicate
{
    /// <summary>
    ///     Determines whether any value in <paramref name="nums" /> appears at least twice.
    /// </summary>
    /// <param name="nums">The array of integers to check.</param>
    /// <returns><see langword="true" /> if any value appears more than once; otherwise, <see langword="false" />.</returns>
    bool ContainsDuplicate(int[] nums);
}