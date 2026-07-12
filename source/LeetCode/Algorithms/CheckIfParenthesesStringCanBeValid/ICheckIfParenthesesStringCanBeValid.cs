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

namespace LeetCode.Algorithms.CheckIfParenthesesStringCanBeValid;

/// <summary>
///     https://leetcode.com/problems/check-if-a-parentheses-string-can-be-valid/description/
/// </summary>
public interface ICheckIfParenthesesStringCanBeValid
{
    /// <summary>
    ///     Determines whether <paramref name="s" /> can be made a valid parentheses string by changing characters whose
    ///     corresponding position in <paramref name="locked" /> is '0'.
    /// </summary>
    /// <param name="s">The parentheses string.</param>
    /// <param name="locked">The binary string where '1' marks characters of <paramref name="s" /> that cannot be changed.</param>
    /// <returns><c>true</c> if <paramref name="s" /> can be made a valid parentheses string; otherwise, <c>false</c>.</returns>
    bool CanBeValid(string s, string locked);
}