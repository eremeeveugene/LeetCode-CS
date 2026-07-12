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

namespace LeetCode.Algorithms.HarshadNumber;

/// <summary>
///     https://leetcode.com/problems/harshad-number/description/
/// </summary>
public interface IHarshadNumber
{
    /// <summary>
    ///     Computes the sum of the digits of <paramref name="x" /> if <paramref name="x" /> is a Harshad number, i.e.
    ///     divisible by the sum of its digits.
    /// </summary>
    /// <param name="x">The number to check.</param>
    /// <returns>The sum of the digits of <paramref name="x" /> if it is a Harshad number; otherwise, -1.</returns>
    int SumOfTheDigitsOfHarshadNumber(int x);
}