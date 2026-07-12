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

namespace LeetCode.Algorithms.NumberOfStepsToReduceNumberToZero;

/// <summary>
///     https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
/// </summary>
public interface INumberOfStepsToReduceNumberToZero
{
    /// <summary>
    ///     Computes the number of steps required to reduce <paramref name="num" /> to zero, where each step halves
    ///     the number if it is even or subtracts 1 if it is odd.
    /// </summary>
    /// <param name="num">The non-negative integer to reduce to zero.</param>
    /// <returns>The number of steps required to reduce <paramref name="num" /> to zero.</returns>
    int NumberOfSteps(int num);
}