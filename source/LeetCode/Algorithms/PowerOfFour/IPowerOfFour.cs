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

namespace LeetCode.Algorithms.PowerOfFour;

/// <summary>
///     https://leetcode.com/problems/power-of-four/
/// </summary>
public interface IPowerOfFour
{
    /// <summary>
    ///     Determines whether <paramref name="n" /> is a power of four.
    /// </summary>
    /// <param name="n">The integer to evaluate.</param>
    /// <returns><see langword="true" /> if <paramref name="n" /> is a power of four; otherwise, <see langword="false" />.</returns>
    bool IsPowerOfFour(int n);
}