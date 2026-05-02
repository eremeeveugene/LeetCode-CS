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

namespace LeetCode.Algorithms.RotatedDigits;

/// <summary>
///     https://leetcode.com/problems/rotated-digits/description/
/// </summary>
public interface IRotatedDigits
{
    /// <summary>
    ///     Counts how many good integers exist in the range from 1 to the specified number.
    /// </summary>
    /// <param name="n">The upper bound of the range to check.</param>
    /// <returns>
    ///     The number of integers in the range [1, <paramref name="n" />] that remain valid after rotating each digit
    ///     by 180 degrees and become a different number.
    /// </returns>
    int RotatedDigits(int n);
}