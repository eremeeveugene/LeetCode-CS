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

namespace LeetCode.Algorithms.HappyNumber;

/// <summary>
///     https://leetcode.com/problems/happy-number/
/// </summary>
public interface IHappyNumber
{
    /// <summary>
    ///     Determines whether <paramref name="n" /> is a happy number, i.e. repeatedly replacing the number with the sum of
    ///     the squares of its digits eventually reaches 1.
    /// </summary>
    /// <param name="n">The number to check.</param>
    /// <returns><c>true</c> if <paramref name="n" /> is a happy number; otherwise, <c>false</c>.</returns>
    bool IsHappy(int n);
}