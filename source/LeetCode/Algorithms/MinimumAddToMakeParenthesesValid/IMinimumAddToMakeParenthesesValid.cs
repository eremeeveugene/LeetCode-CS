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

namespace LeetCode.Algorithms.MinimumAddToMakeParenthesesValid;

/// <summary>
///     https://leetcode.com/problems/minimum-add-to-make-parentheses-valid/description/
/// </summary>
public interface IMinimumAddToMakeParenthesesValid
{
    /// <summary>
    ///     Finds the minimum number of parentheses that must be inserted into <paramref name="s" /> to make it a
    ///     valid parentheses string.
    /// </summary>
    /// <param name="s">The string of parentheses to validate.</param>
    /// <returns>The minimum number of insertions required to make <paramref name="s" /> valid.</returns>
    int MinAddToMakeValid(string s);
}