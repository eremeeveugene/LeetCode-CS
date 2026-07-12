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

namespace LeetCode.Algorithms.MakeTheStringGreat;

/// <summary>
///     https://leetcode.com/problems/make-the-string-great/
/// </summary>
public interface IMakeTheStringGreat
{
    /// <summary>
    ///     Repeatedly removes adjacent pairs of characters in <paramref name="s" /> that are the same letter in opposite
    ///     case until no such pair remains.
    /// </summary>
    /// <param name="s">The string to reduce to its "good" form.</param>
    /// <returns>The resulting good string after all adjacent same-letter, opposite-case pairs have been removed.</returns>
    string MakeGood(string s);
}