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

namespace LeetCode.Algorithms.ConvertIntegerToTheSumOfTwoNoZeroIntegers;

/// <summary>
///     https://leetcode.com/problems/convert-integer-to-the-sum-of-two-no-zero-integers/description/
/// </summary>
public interface IConvertIntegerToTheSumOfTwoNoZeroIntegers
{
    /// <summary>
    ///     Finds two positive integers whose sum equals <paramref name="n" /> and whose decimal representations contain
    ///     no digit 0.
    /// </summary>
    /// <param name="n">The target integer to split into two no-zero integers.</param>
    /// <returns>An array containing the two no-zero integers that sum to <paramref name="n" />.</returns>
    int[] GetNoZeroIntegers(int n);
}