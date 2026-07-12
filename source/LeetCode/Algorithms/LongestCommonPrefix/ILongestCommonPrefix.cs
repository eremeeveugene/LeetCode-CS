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

namespace LeetCode.Algorithms.LongestCommonPrefix;

/// <summary>
///     https://leetcode.com/problems/longest-common-prefix/description/
/// </summary>
public interface ILongestCommonPrefix
{
    /// <summary>
    ///     Finds the longest common prefix string shared by all strings in <paramref name="strs" />.
    /// </summary>
    /// <param name="strs">The array of strings to compare.</param>
    /// <returns>The longest common prefix, or an empty string if there is none.</returns>
    string LongestCommonPrefix(string[] strs);
}