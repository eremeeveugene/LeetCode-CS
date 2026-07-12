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

namespace LeetCode.Algorithms.ValidParenthesisString;

/// <summary>
///     https://leetcode.com/problems/valid-parenthesis-string/
/// </summary>
public interface IValidParenthesisString
{
    /// <summary>
    ///     Determines whether <paramref name="s" />, which may contain <c>'('</c>, <c>')'</c>, and <c>'*'</c>
    ///     (treated as <c>'('</c>, <c>')'</c>, or an empty string), can represent a valid parenthesis sequence.
    /// </summary>
    /// <param name="s">The string consisting of <c>'('</c>, <c>')'</c>, and <c>'*'</c> characters to validate.</param>
    /// <returns><see langword="true" /> if <paramref name="s" /> can be a valid parenthesis string; otherwise, <see langword="false" />.</returns>
    bool CheckValidString(string s);
}