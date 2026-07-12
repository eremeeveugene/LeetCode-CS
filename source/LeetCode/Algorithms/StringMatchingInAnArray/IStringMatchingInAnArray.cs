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

namespace LeetCode.Algorithms.StringMatchingInAnArray;

/// <summary>
///     https://leetcode.com/problems/string-matching-in-an-array/
/// </summary>
public interface IStringMatchingInAnArray
{
    /// <summary>
    ///     Finds all strings in <paramref name="words" /> that are a substring of another string in the array.
    /// </summary>
    /// <param name="words">The array of distinct strings to search.</param>
    /// <returns>A list of the strings in <paramref name="words" /> that are substrings of another word in the array.</returns>
    IList<string> StringMatching(string[] words);
}