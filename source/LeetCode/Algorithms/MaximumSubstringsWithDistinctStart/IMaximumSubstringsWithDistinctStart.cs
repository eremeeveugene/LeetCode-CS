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

namespace LeetCode.Algorithms.MaximumSubstringsWithDistinctStart;

/// <summary>
///     https://leetcode.com/problems/maximum-substrings-with-distinct-start/description/
/// </summary>
public interface IMaximumSubstringsWithDistinctStart
{
    /// <summary>
    ///     Finds the maximum number of non-overlapping substrings that can be chosen from <paramref name="s" /> such
    ///     that each substring starts with a character that appears only once in that substring.
    /// </summary>
    /// <param name="s">The string to split into substrings.</param>
    /// <returns>The maximum number of qualifying non-overlapping substrings.</returns>
    int MaxDistinct(string s);
}