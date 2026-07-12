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

namespace LeetCode.Algorithms.PerfectSquares;

/// <summary>
///     https://leetcode.com/problems/perfect-squares/description/
/// </summary>
public interface IPerfectSquares
{
    /// <summary>
    ///     Finds the least number of perfect square numbers that sum to <paramref name="n" />.
    /// </summary>
    /// <param name="n">The target integer to sum to using perfect squares.</param>
    /// <returns>The minimum count of perfect squares that sum to <paramref name="n" />.</returns>
    int NumSquares(int n);
}