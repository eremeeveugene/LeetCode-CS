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

namespace LeetCode.Algorithms.SplitStringsBySeparator;

/// <summary>
///     https://leetcode.com/problems/split-strings-by-separator/description/
/// </summary>
public interface ISplitStringsBySeparator
{
    /// <summary>
    ///     Splits each string in <paramref name="words" /> by <paramref name="separator" /> and flattens the
    ///     results into a single list, excluding any empty strings.
    /// </summary>
    /// <param name="words">The list of strings to split.</param>
    /// <param name="separator">The character used to split each string.</param>
    /// <returns>A flattened list of the non-empty substrings produced by splitting each word in <paramref name="words" />.</returns>
    IList<string> SplitWordsBySeparator(IList<string> words, char separator);
}