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

namespace LeetCode.Algorithms.LargestIntegerWithGivenDigitSum;

/// <summary>
///     https://leetcode.com/problems/largest-integer-with-given-digit-sum/description/
/// </summary>
public interface ILargestIntegerWithGivenDigitSum
{
    /// <summary>
    ///     Determines the largest non-negative integer that has at most <paramref name="n" /> digits and whose digits
    ///     sum to <paramref name="s" />.
    /// </summary>
    /// <param name="n">The maximum number of digits allowed in the result.</param>
    /// <param name="s">The required sum of the digits of the result.</param>
    /// <returns>
    ///     The largest integer with at most <paramref name="n" /> digits whose digit sum is <paramref name="s" />, or
    ///     <c>-1</c> if no such integer exists.
    /// </returns>
    int LargestNumber(int n, int s);
}