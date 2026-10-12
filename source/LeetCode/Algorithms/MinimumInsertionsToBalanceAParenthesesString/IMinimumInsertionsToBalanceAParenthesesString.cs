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

namespace LeetCode.Algorithms.MinimumInsertionsToBalanceAParenthesesString;

/// <summary>
///     https://leetcode.com/problems/minimum-insertions-to-balance-a-parentheses-string/description/
/// </summary>
public interface IMinimumInsertionsToBalanceAParenthesesString
{
    /// <summary>
    ///     Calculates the minimum number of insertions needed to balance a parentheses string, where every '(' must be
    ///     matched by two consecutive ')' characters.
    /// </summary>
    /// <param name="s">A string consisting of '(' and ')' characters.</param>
    /// <returns>The minimum number of insertions needed to make the string balanced.</returns>
    int MinInsertions(string s);
}