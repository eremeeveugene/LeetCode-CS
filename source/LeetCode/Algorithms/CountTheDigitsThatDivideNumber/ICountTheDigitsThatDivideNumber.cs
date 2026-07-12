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

namespace LeetCode.Algorithms.CountTheDigitsThatDivideNumber;

/// <summary>
///     https://leetcode.com/problems/count-the-digits-that-divide-a-number/
/// </summary>
public interface ICountTheDigitsThatDivideNumber
{
    /// <summary>
    ///     Counts the digits of <paramref name="num" /> that evenly divide <paramref name="num" />.
    /// </summary>
    /// <param name="num">The number whose digits are examined.</param>
    /// <returns>The number of digits that divide <paramref name="num" />.</returns>
    int CountDigits(int num);
}