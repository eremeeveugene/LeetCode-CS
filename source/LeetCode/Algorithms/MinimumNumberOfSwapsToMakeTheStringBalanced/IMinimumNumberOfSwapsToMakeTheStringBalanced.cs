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

namespace LeetCode.Algorithms.MinimumNumberOfSwapsToMakeTheStringBalanced;

/// <summary>
///     https://leetcode.com/problems/minimum-number-of-swaps-to-make-the-string-balanced/description/
/// </summary>
public interface IMinimumNumberOfSwapsToMakeTheStringBalanced
{
    /// <summary>
    ///     Finds the minimum number of swaps required to make the bracket sequence <paramref name="s" /> balanced.
    /// </summary>
    /// <param name="s">The string consisting of an equal number of '[' and ']' brackets.</param>
    /// <returns>The minimum number of swaps needed to balance <paramref name="s" />.</returns>
    int MinSwaps(string s);
}