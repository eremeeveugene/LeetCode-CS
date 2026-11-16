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

namespace LeetCode.Algorithms.CalculateDigitSumOfAString;

/// <summary>
///     https://leetcode.com/problems/calculate-digit-sum-of-a-string/description/
/// </summary>
public interface ICalculateDigitSumOfAString
{
    /// <summary>
    ///     Repeatedly splits <paramref name="s" /> into consecutive groups of size <paramref name="k" />, replaces each
    ///     group with the string representation of the sum of its digits, and merges the groups, while the length of
    ///     the string is greater than <paramref name="k" />.
    /// </summary>
    /// <param name="s">The string consisting of digits only.</param>
    /// <param name="k">The size of each group.</param>
    /// <returns>The string after all rounds have been completed.</returns>
    string DigitSum(string s, int k);
}