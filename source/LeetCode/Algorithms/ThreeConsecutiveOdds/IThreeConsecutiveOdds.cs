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

namespace LeetCode.Algorithms.ThreeConsecutiveOdds;

/// <summary>
///     https://leetcode.com/problems/three-consecutive-odds/
/// </summary>
public interface IThreeConsecutiveOdds
{
    /// <summary>
    ///     Determines whether <paramref name="arr" /> contains three consecutive odd numbers.
    /// </summary>
    /// <param name="arr">The array of integers to inspect.</param>
    /// <returns><see langword="true" /> if three consecutive odd numbers exist; otherwise, <see langword="false" />.</returns>
    bool ThreeConsecutiveOdds(int[] arr);
}