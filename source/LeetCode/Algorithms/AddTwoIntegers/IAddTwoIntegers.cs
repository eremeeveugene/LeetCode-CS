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

namespace LeetCode.Algorithms.AddTwoIntegers;

/// <summary>
///     https://leetcode.com/problems/add-two-integers/
/// </summary>
public interface IAddTwoIntegers
{
    /// <summary>
    ///     Returns the sum of the two integers <paramref name="num1" /> and <paramref name="num2" />.
    /// </summary>
    /// <param name="num1">The first integer.</param>
    /// <param name="num2">The second integer.</param>
    /// <returns>The sum of the two integers.</returns>
    int Sum(int num1, int num2);
}