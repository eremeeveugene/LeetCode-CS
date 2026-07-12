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

namespace LeetCode.Algorithms.FindLongestSpecialSubstringThatOccursThrice1;

/// <summary>
///     https://leetcode.com/problems/find-longest-special-substring-that-occurs-thrice-i/description/
/// </summary>
public interface IFindLongestSpecialSubstringThatOccursThrice1
{
    /// <summary>
    ///     Finds the length of the longest special substring (consisting of a single repeated character) that occurs at
    ///     least three times in <paramref name="s" />.
    /// </summary>
    /// <param name="s">The string to search.</param>
    /// <returns>The length of the longest special substring occurring at least three times, or -1 if none exists.</returns>
    int MaximumLength(string s);
}