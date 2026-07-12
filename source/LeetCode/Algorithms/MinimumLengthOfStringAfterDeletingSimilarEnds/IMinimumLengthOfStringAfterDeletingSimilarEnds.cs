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

namespace LeetCode.Algorithms.MinimumLengthOfStringAfterDeletingSimilarEnds;

/// <summary>
///     https://leetcode.com/problems/minimum-length-of-string-after-deleting-similar-ends/description/
/// </summary>
public interface IMinimumLengthOfStringAfterDeletingSimilarEnds
{
    /// <summary>
    ///     Repeatedly removes matching non-empty prefixes and suffixes of equal characters from
    ///     <paramref name="s" /> and finds the minimum possible length of the remaining string.
    /// </summary>
    /// <param name="s">The string to reduce.</param>
    /// <returns>The minimum length of the string after all possible deletions.</returns>
    int MinimumLength(string s);
}