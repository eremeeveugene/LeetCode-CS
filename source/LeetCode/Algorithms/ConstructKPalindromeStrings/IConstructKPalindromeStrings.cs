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

namespace LeetCode.Algorithms.ConstructKPalindromeStrings;

/// <summary>
///     https://leetcode.com/problems/construct-k-palindrome-strings/description/
/// </summary>
public interface IConstructKPalindromeStrings
{
    /// <summary>
    ///     Determines whether all characters of <paramref name="s" /> can be used to construct exactly
    ///     <paramref name="k" /> non-empty palindrome strings.
    /// </summary>
    /// <param name="s">The string whose characters are used.</param>
    /// <param name="k">The number of palindrome strings to construct.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="k" /> palindrome strings can be constructed from
    ///     <paramref name="s" />; otherwise, <see langword="false" />.
    /// </returns>
    bool CanConstruct(string s, int k);
}