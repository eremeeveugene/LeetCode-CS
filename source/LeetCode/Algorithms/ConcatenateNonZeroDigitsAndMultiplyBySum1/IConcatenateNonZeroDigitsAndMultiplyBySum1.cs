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

namespace LeetCode.Algorithms.ConcatenateNonZeroDigitsAndMultiplyBySum1;

/// <summary>
///     https://leetcode.com/problems/concatenate-non-zero-digits-and-multiply-by-sum-i/description/
/// </summary>
public interface IConcatenateNonZeroDigitsAndMultiplyBySum1
{
    /// <summary>
    ///     Concatenates the non-zero digits of <paramref name="n" /> into a new number and multiplies it by the sum of
    ///     those digits.
    /// </summary>
    /// <param name="n">The integer whose digits are processed.</param>
    /// <returns>The concatenated non-zero digits of <paramref name="n" /> multiplied by their sum.</returns>
    long SumAndMultiply(int n);
}