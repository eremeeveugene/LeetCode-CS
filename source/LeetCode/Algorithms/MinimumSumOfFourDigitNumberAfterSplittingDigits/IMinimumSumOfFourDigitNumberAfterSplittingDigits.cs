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

namespace LeetCode.Algorithms.MinimumSumOfFourDigitNumberAfterSplittingDigits;

/// <summary>
///     https://leetcode.com/problems/minimum-sum-of-four-digit-number-after-splitting-digits/description/
/// </summary>
public interface IMinimumSumOfFourDigitNumberAfterSplittingDigits
{
    /// <summary>
    ///     Splits the four digits of <paramref name="num" /> into two new two-digit numbers so that their sum is as
    ///     small as possible.
    /// </summary>
    /// <param name="num">The four-digit number whose digits should be split into two new numbers.</param>
    /// <returns>The minimum possible sum of the two new numbers formed from the digits of <paramref name="num" />.</returns>
    int MinimumSum(int num);
}