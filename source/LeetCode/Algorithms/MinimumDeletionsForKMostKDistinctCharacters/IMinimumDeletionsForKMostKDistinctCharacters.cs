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

namespace LeetCode.Algorithms.MinimumDeletionsForKMostKDistinctCharacters;

/// <summary>
///     https://leetcode.com/problems/minimum-deletions-for-at-most-k-distinct-characters/description/
/// </summary>
public interface IMinimumDeletionsForKMostKDistinctCharacters
{
    /// <summary>
    ///     Finds the minimum number of characters that must be deleted from <paramref name="s" /> so that it
    ///     contains at most <paramref name="k" /> distinct characters.
    /// </summary>
    /// <param name="s">The string to reduce.</param>
    /// <param name="k">The maximum number of distinct characters allowed after deletion.</param>
    /// <returns>The minimum number of character deletions required.</returns>
    int MinDeletion(string s, int k);
}