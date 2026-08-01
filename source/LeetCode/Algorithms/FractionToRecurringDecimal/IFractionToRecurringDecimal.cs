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

namespace LeetCode.Algorithms.FractionToRecurringDecimal;

/// <summary>
///     https://leetcode.com/problems/fraction-to-recurring-decimal/description/
/// </summary>
public interface IFractionToRecurringDecimal
{
    /// <summary>
    ///     Converts the fraction represented by <paramref name="numerator" /> and <paramref name="denominator" /> into its string decimal representation,
    ///     enclosing any repeating part in parentheses.
    /// </summary>
    /// <param name="numerator">The numerator of the fraction.</param>
    /// <param name="denominator">The denominator of the fraction.</param>
    /// <returns>The decimal representation of the fraction as a string.</returns>
    string FractionToDecimal(int numerator, int denominator);
}