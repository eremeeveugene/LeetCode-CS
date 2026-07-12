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

namespace LeetCode.Algorithms.MaximumSwap;

/// <summary>
///     https://leetcode.com/problems/maximum-swap/description/
/// </summary>
public interface IMaximumSwap
{
    /// <summary>
    ///     Swaps two digits of <paramref name="num" /> at most once to obtain the largest possible value.
    /// </summary>
    /// <param name="num">The non-negative integer whose digits may be swapped.</param>
    /// <returns>The maximum value obtainable by swapping two digits of <paramref name="num" /> at most once.</returns>
    int MaximumSwap(int num);
}