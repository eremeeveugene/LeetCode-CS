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

namespace LeetCode.Algorithms.SplitStringIntoTheMaxNumberOfUniqueSubstrings;

/// <summary>
///     https://leetcode.com/problems/split-a-string-into-the-max-number-of-unique-substrings/description/
/// </summary>
public interface ISplitStringIntoTheMaxNumberOfUniqueSubstrings
{
    /// <summary>
    ///     Splits <paramref name="s" /> into the maximum possible number of non-empty substrings such that all
    ///     of the substrings are unique.
    /// </summary>
    /// <param name="s">The string to split.</param>
    /// <returns>The maximum number of unique substrings <paramref name="s" /> can be split into.</returns>
    int MaxUniqueSplit(string s);
}