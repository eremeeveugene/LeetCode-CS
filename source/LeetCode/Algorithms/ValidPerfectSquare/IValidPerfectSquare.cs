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

namespace LeetCode.Algorithms.ValidPerfectSquare;

/// <summary>
///     https://leetcode.com/problems/valid-perfect-square/
/// </summary>
public interface IValidPerfectSquare
{
    /// <summary>
    ///     Determines whether <paramref name="num" /> is a perfect square.
    /// </summary>
    /// <param name="num">The positive integer to check.</param>
    /// <returns><see langword="true" /> if <paramref name="num" /> is a perfect square; otherwise, <see langword="false" />.</returns>
    bool IsPerfectSquare(int num);
}