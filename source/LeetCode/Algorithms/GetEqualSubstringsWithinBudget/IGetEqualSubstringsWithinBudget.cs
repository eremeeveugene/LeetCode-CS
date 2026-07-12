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

namespace LeetCode.Algorithms.GetEqualSubstringsWithinBudget;

/// <summary>
///     https://leetcode.com/problems/get-equal-substrings-within-budget/description/
/// </summary>
public interface IGetEqualSubstringsWithinBudget
{
    /// <summary>
    ///     Finds the maximum length of a substring of <paramref name="s" /> that can be changed to the corresponding
    ///     substring of <paramref name="t" /> with a total cost not exceeding <paramref name="maxCost" />, where the cost of
    ///     changing a character is the absolute difference of the ASCII values.
    /// </summary>
    /// <param name="s">The source string.</param>
    /// <param name="t">The target string of the same length as <paramref name="s" />.</param>
    /// <param name="maxCost">The maximum allowed total cost.</param>
    /// <returns>The maximum length of a substring that can be changed within the budget.</returns>
    int EqualSubstring(string s, string t, int maxCost);
}