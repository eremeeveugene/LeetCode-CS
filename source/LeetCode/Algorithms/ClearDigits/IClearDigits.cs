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

namespace LeetCode.Algorithms.ClearDigits;

/// <summary>
///     https://leetcode.com/problems/clear-digits/description/
/// </summary>
public interface IClearDigits
{
    /// <summary>
    ///     Repeatedly removes each digit in <paramref name="s" /> along with the closest non-digit character to its left.
    /// </summary>
    /// <param name="s">The string containing lowercase letters and digits.</param>
    /// <returns>The resulting string after removing all digits and their closest left non-digit characters.</returns>
    string ClearDigits(string s);
}