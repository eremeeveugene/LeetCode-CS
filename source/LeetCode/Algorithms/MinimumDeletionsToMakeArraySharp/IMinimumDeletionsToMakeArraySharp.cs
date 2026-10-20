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

namespace LeetCode.Algorithms.MinimumDeletionsToMakeArraySharp;

/// <summary>
///     https://leetcode.com/problems/minimum-deletions-to-make-array-sharp/description/
/// </summary>
public interface IMinimumDeletionsToMakeArraySharp
{
    /// <summary>
    ///     Computes the minimum number of deletions needed so that every pair of adjacent elements in
    ///     <paramref name="nums" /> has a non-zero bitwise XOR.
    /// </summary>
    /// <param name="nums">The array of positive integers to make sharp.</param>
    /// <returns>The minimum number of deletions needed to make <paramref name="nums" /> sharp.</returns>
    int MinDeletions(int[] nums);
}