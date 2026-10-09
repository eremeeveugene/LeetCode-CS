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

namespace LeetCode.Algorithms.RemoveOutermostParentheses;

/// <summary>
///     https://leetcode.com/problems/remove-outermost-parentheses/description/
/// </summary>
public interface IRemoveOutermostParentheses
{
    /// <summary>
    ///     Removes the outermost parentheses of every primitive valid parentheses string in the decomposition of the input.
    /// </summary>
    /// <param name="s">A valid parentheses string consisting of '(' and ')' characters.</param>
    /// <returns>The string with the outermost parentheses of every primitive component removed.</returns>
    string RemoveOuterParentheses(string s);
}