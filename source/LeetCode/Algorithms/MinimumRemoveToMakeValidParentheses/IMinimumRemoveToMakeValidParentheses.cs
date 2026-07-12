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

namespace LeetCode.Algorithms.MinimumRemoveToMakeValidParentheses;

/// <summary>
///     https://leetcode.com/problems/minimum-remove-to-make-valid-parentheses/
/// </summary>
public interface IMinimumRemoveToMakeValidParentheses
{
    /// <summary>
    ///     Removes the minimum number of parentheses from <paramref name="s" /> so that the resulting string is a
    ///     valid parentheses sequence.
    /// </summary>
    /// <param name="s">The string containing lowercase letters and parentheses characters.</param>
    /// <returns>A valid parentheses string obtained by removing the minimum number of characters from <paramref name="s" />.</returns>
    string MinRemoveToMakeValid(string s);
}