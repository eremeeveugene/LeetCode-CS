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

namespace LeetCode.Algorithms.RemoveAllOccurrencesOfSubstring;

/// <summary>
///     https://leetcode.com/problems/remove-all-occurrences-of-a-substring/description/
/// </summary>
public interface IRemoveAllOccurrencesOfSubstring
{
    /// <summary>
    ///     Repeatedly removes the leftmost occurrence of <paramref name="part" /> from <paramref name="s" /> until no
    ///     occurrences remain.
    /// </summary>
    /// <param name="s">The string to remove occurrences from.</param>
    /// <param name="part">The substring to repeatedly remove.</param>
    /// <returns>The resulting string after all occurrences of <paramref name="part" /> have been removed.</returns>
    string RemoveOccurrences(string s, string part);
}