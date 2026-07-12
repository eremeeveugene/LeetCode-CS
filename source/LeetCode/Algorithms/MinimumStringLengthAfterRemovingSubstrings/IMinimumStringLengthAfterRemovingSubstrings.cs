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

namespace LeetCode.Algorithms.MinimumStringLengthAfterRemovingSubstrings;

/// <summary>
///     https://leetcode.com/problems/minimum-string-length-after-removing-substrings/description/
/// </summary>
public interface IMinimumStringLengthAfterRemovingSubstrings
{
    /// <summary>
    ///     Repeatedly removes occurrences of the substrings "AB" and "CD" from <paramref name="s" /> and returns the
    ///     length of the string that remains once no more removals are possible.
    /// </summary>
    /// <param name="s">The string to repeatedly remove "AB" and "CD" substrings from.</param>
    /// <returns>The length of the resulting string after all possible removals.</returns>
    int MinLength(string s);
}