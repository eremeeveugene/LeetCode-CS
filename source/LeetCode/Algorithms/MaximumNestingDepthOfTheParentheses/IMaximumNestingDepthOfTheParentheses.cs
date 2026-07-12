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

namespace LeetCode.Algorithms.MaximumNestingDepthOfTheParentheses;

/// <summary>
///     https://leetcode.com/problems/maximum-nesting-depth-of-the-parentheses/
/// </summary>
public interface IMaximumNestingDepthOfTheParentheses
{
    /// <summary>
    ///     Computes the maximum nesting depth of the parentheses in the valid parentheses string <paramref name="s" />.
    /// </summary>
    /// <param name="s">The valid parentheses string (which may also contain digits, '+' and '-') to analyze.</param>
    /// <returns>The maximum depth of nested parentheses in <paramref name="s" />.</returns>
    int MaxDepth(string s);
}