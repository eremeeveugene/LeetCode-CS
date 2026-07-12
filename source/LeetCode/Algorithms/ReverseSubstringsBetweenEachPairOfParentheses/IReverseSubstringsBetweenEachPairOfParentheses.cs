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

namespace LeetCode.Algorithms.ReverseSubstringsBetweenEachPairOfParentheses;

/// <summary>
///     https://leetcode.com/problems/reverse-substrings-between-each-pair-of-parentheses/description/
/// </summary>
public interface IReverseSubstringsBetweenEachPairOfParentheses
{
    /// <summary>
    ///     Reverses the substring enclosed by every matching pair of parentheses in <paramref name="s" />, from the
    ///     innermost pair outward, and removes all parentheses from the result.
    /// </summary>
    /// <param name="s">The string containing lowercase letters and matched parentheses.</param>
    /// <returns>The resulting string with all parenthesized substrings reversed and parentheses removed.</returns>
    string ReverseParentheses(string s);
}