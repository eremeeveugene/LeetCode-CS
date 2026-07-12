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

namespace LeetCode.Algorithms.TakeGiftsFromTheRichestPile;

/// <summary>
///     https://leetcode.com/problems/take-gifts-from-the-richest-pile/description/
/// </summary>
public interface ITakeGiftsFromTheRichestPile
{
    /// <summary>
    ///     Repeats <paramref name="k" /> times the operation of replacing the largest pile in
    ///     <paramref name="gifts" /> with the floor of its square root, then computes the total number of gifts
    ///     remaining across all piles.
    /// </summary>
    /// <param name="gifts">The array representing the number of gifts in each pile.</param>
    /// <param name="k">The number of times to reduce the largest pile.</param>
    /// <returns>The total number of gifts remaining after performing the operation <paramref name="k" /> times.</returns>
    long PickGifts(int[] gifts, int k);
}