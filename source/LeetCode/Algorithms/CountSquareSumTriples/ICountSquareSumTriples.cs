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

namespace LeetCode.Algorithms.CountSquareSumTriples;

/// <summary>
///     https://leetcode.com/problems/count-square-sum-triples/description/
/// </summary>
public interface ICountSquareSumTriples
{
    /// <summary>
    ///     Counts the square triples (a, b, c) with all values between one and <paramref name="n" /> such that
    ///     a^2 + b^2 = c^2.
    /// </summary>
    /// <param name="n">The inclusive upper bound for the triple values.</param>
    /// <returns>The number of square sum triples.</returns>
    int CountTriples(int n);
}