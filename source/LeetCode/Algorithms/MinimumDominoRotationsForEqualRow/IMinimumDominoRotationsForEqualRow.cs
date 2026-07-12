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

namespace LeetCode.Algorithms.MinimumDominoRotationsForEqualRow;

/// <summary>
///     https://leetcode.com/problems/minimum-domino-rotations-for-equal-row/description/
/// </summary>
public interface IMinimumDominoRotationsForEqualRow
{
    /// <summary>
    ///     Finds the minimum number of domino rotations, swapping the top and bottom value of a domino, needed to
    ///     make every value in <paramref name="tops" /> the same or every value in <paramref name="bottoms" /> the
    ///     same.
    /// </summary>
    /// <param name="tops">The array of top values of each domino.</param>
    /// <param name="bottoms">The array of bottom values of each domino.</param>
    /// <returns>The minimum number of rotations required, or -1 if it is impossible.</returns>
    int MinDominoRotations(int[] tops, int[] bottoms);
}