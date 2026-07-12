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

namespace LeetCode.Algorithms.DifferentWaysToAddParentheses;

/// <summary>
///     https://leetcode.com/problems/different-ways-to-add-parentheses/
/// </summary>
public interface IDifferentWaysToAddParentheses
{
    /// <summary>
    ///     Computes all possible results from grouping the numbers and operators in <paramref name="expression" /> in
    ///     every possible way.
    /// </summary>
    /// <param name="expression">The expression of numbers and the operators '+', '-', and '*'.</param>
    /// <returns>A list of all possible results in any order.</returns>
    IList<int> DiffWaysToCompute(string expression);
}