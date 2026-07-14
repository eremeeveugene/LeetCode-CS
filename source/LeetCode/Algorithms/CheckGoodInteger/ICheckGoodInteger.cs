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

namespace LeetCode.Algorithms.CheckGoodInteger;

/// <summary>
///     https://leetcode.com/problems/check-good-integer/description/
/// </summary>
public interface ICheckGoodInteger
{
    /// <summary>
    ///     Determines whether <paramref name="n" /> is good, where an integer is good if the sum of the squares of its
    ///     digits minus the sum of its digits is greater than or equal to 50.
    /// </summary>
    /// <param name="n">The positive integer to evaluate.</param>
    /// <returns><c>true</c> if <paramref name="n" /> is good; otherwise, <c>false</c>.</returns>
    bool IsGood(int n);
}