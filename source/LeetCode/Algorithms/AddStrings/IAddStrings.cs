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

namespace LeetCode.Algorithms.AddStrings;

/// <summary>
///     https://leetcode.com/problems/add-strings/description/
/// </summary>
public interface IAddStrings
{
    /// <summary>
    ///     Adds the two non-negative integers represented as strings <paramref name="num1" /> and <paramref name="num2" />
    ///     and returns their sum as a string.
    /// </summary>
    /// <param name="num1">The first non-negative integer represented as a string.</param>
    /// <param name="num2">The second non-negative integer represented as a string.</param>
    /// <returns>The sum of the two numbers represented as a string.</returns>
    string AddStrings(string num1, string num2);
}