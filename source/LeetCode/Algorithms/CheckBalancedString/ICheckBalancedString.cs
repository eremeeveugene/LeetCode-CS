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

namespace LeetCode.Algorithms.CheckBalancedString;

/// <summary>
///     https://leetcode.com/problems/check-balanced-string/description/
/// </summary>
public interface ICheckBalancedString
{
    /// <summary>
    ///     Determines whether the digit string <paramref name="num" /> is balanced, i.e. the sum of digits at even indices
    ///     equals the sum of digits at odd indices.
    /// </summary>
    /// <param name="num">The string of digits to check.</param>
    /// <returns><c>true</c> if <paramref name="num" /> is balanced; otherwise, <c>false</c>.</returns>
    bool IsBalanced(string num);
}