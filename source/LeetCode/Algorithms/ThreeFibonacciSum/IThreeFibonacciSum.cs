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

namespace LeetCode.Algorithms.ThreeFibonacciSum;

/// <summary>
///     https://leetcode.com/problems/three-fibonacci-sum/description/
/// </summary>
public interface IThreeFibonacciSum
{
    /// <summary>
    ///     Determines whether <paramref name="n" /> can be expressed as the sum of three consecutive terms of the
    ///     Fibonacci sequence that starts with 0 and 1.
    /// </summary>
    /// <param name="n">The positive integer to check.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="n" /> is the sum of three consecutive Fibonacci terms;
    ///     otherwise, <see langword="false" />.
    /// </returns>
    bool ThreeFibonacciSum(int n);
}