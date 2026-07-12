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

namespace LeetCode.Algorithms.FindTheIndexOfTheFirstOccurrenceInString;

/// <summary>
///     https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/description/
/// </summary>
public interface IFindTheIndexOfTheFirstOccurrenceInString
{
    /// <summary>
    ///     Finds the index of the first occurrence of <paramref name="needle" /> in <paramref name="haystack" />.
    /// </summary>
    /// <param name="haystack">The string to search in.</param>
    /// <param name="needle">The string to search for.</param>
    /// <returns>The index of the first occurrence of <paramref name="needle" /> in <paramref name="haystack" />, or -1 if not found.</returns>
    int StrStr(string haystack, string needle);
}