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

namespace LeetCode.Algorithms.FizzBuzz;

/// <summary>
///     https://leetcode.com/problems/fizz-buzz/description/
/// </summary>
public interface IFizzBuzz
{
    /// <summary>
    ///     Returns the FizzBuzz sequence for the numbers from 1 to <paramref name="n" />, where multiples of 3 are
    ///     replaced with "Fizz", multiples of 5 with "Buzz", and multiples of both with "FizzBuzz".
    /// </summary>
    /// <param name="n">The upper bound of the sequence.</param>
    /// <returns>The FizzBuzz string representation of the numbers from 1 to <paramref name="n" />.</returns>
    IList<string> FizzBuzz(int n);
}