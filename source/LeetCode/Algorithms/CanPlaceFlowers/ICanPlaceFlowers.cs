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

namespace LeetCode.Algorithms.CanPlaceFlowers;

/// <summary>
///     https://leetcode.com/problems/can-place-flowers/description/
/// </summary>
public interface ICanPlaceFlowers
{
    /// <summary>
    ///     Determines whether <paramref name="flower" /> new flowers can be planted in <paramref name="flowerbed" /> without
    ///     violating the no-adjacent-flowers rule.
    /// </summary>
    /// <param name="flowerbed">
    ///     An array where <c>0</c> represents an empty plot and <c>1</c> represents a plot with a planted flower.
    /// </param>
    /// <param name="flower">The number of new flowers to plant.</param>
    /// <returns><c>true</c> if <paramref name="flower" /> flowers can be planted without two flowers becoming adjacent; otherwise, <c>false</c>.</returns>
    bool CanPlaceFlowers(int[] flowerbed, int flower);
}