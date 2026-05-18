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

namespace LeetCode.Algorithms.CheckAdjacentDigitDifferences;

/// <summary>
///     https://leetcode.com/problems/check-adjacent-digit-differences/description/
/// </summary>
public interface ICheckAdjacentDigitDifferences
{
    /// <summary>
    ///     Checks whether the absolute difference between every pair of adjacent digits is at most two.
    /// </summary>
    /// <param name="s">The numeric string whose adjacent digit differences should be checked.</param>
    /// <returns><see langword="true" /> if every adjacent digit difference is at most two; otherwise, <see langword="false" />.</returns>
    bool IsAdjacentDiffAtMostTwo(string s);
}