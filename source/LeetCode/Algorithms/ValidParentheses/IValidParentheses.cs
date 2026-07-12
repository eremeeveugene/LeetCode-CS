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

namespace LeetCode.Algorithms.ValidParentheses;

/// <summary>
///     https://leetcode.com/problems/valid-parentheses/description/
/// </summary>
public interface IValidParentheses
{
    /// <summary>
    ///     Determines whether the brackets in <paramref name="s" /> — <c>()</c>, <c>[]</c>, and <c>{}</c> — are
    ///     properly opened and closed in the correct order.
    /// </summary>
    /// <param name="s">The string consisting solely of bracket characters to validate.</param>
    /// <returns><see langword="true" /> if the brackets form a valid sequence; otherwise, <see langword="false" />.</returns>
    bool IsValid(string s);
}