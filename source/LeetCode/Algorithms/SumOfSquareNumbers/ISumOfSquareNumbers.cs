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

namespace LeetCode.Algorithms.SumOfSquareNumbers;

/// <summary>
///     https://leetcode.com/problems/sum-of-square-numbers/
/// </summary>
public interface ISumOfSquareNumbers
{
    /// <summary>
    ///     Determines whether <paramref name="c" /> can be expressed as the sum of the squares of two non-negative
    ///     integers.
    /// </summary>
    /// <param name="c">The target integer to test.</param>
    /// <returns><see langword="true" /> if such a pair of integers exists; otherwise, <see langword="false" />.</returns>
    bool JudgeSquareSum(int c);
}